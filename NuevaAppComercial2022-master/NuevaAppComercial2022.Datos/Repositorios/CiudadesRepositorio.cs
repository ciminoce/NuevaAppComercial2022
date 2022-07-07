using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class CiudadesRepositorio
    {
        public readonly ConexionBd conexionBd;

        public CiudadesRepositorio()
        {
            conexionBd=new ConexionBd();
        }

        public List<Ciudad> GetLista()
        {
            List<Ciudad>lista=new List<Ciudad>();
            try
            {
                using (var cn=conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ciudad ciudad = ConstruirCiudad(reader);
                            lista.Add(ciudad);
                        }

                    }

                    SetPaises(lista, cn);
                }

                return lista.OrderBy(c=>c.Pais.NombrePais)
                    .ThenBy(c=>c.NombreCiudad).ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void SetPaises(List<Ciudad> lista, SqlConnection cn)
        {
            foreach (var ciudad in lista)
            {
                ciudad.Pais = SetPais(ciudad.PaisId, cn);
            }
        }

        private Pais SetPais(int ciudadPaisId, SqlConnection cn)
        {
            Pais pais = null;
            var cadenaComando = "SELECT PaisId, NombrePais, RowVersion FROM Paises WHERE PaisId=@id";
            var comando=new SqlCommand(cadenaComando,cn);
            comando.Parameters.AddWithValue("@id", ciudadPaisId);
            using (var reader=comando.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    pais = ConstruirPais(reader);
                }
            }

            return pais;
        }

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais()
            {
                PaisId = reader.GetInt32(0),
                NombrePais = reader.GetString(1),
                RowVersion = (byte[]) reader[2]
            };
        }

        private Ciudad ConstruirCiudad(SqlDataReader reader)
        {
            return new Ciudad()
            {
                CiudadId = reader.GetInt32(0),
                NombreCiudad = reader.GetString(1),
                PaisId = reader.GetInt32(2),
                RowVersion = (byte[]) reader[3]

            };
        }

        public int Agregar(Ciudad ciudad)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn=conexionBd.AbrirConexion())
                {
                    var cadenaComando = "INSERT INTO Ciudades (NombreCiudad, PaisId) VALUES(@nom , @paisId)";
                    var comando=new SqlCommand(cadenaComando,cn);
                    comando.Parameters.AddWithValue("@nom", ciudad.NombreCiudad);
                    comando.Parameters.AddWithValue("@paisId", ciudad.PaisId);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados==0)
                    {
                        throw new Exception("No se agregaron registros");
                    }
                    else
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        comando=new SqlCommand(cadenaComando,cn);
                        ciudad.CiudadId = (int) (decimal) comando.ExecuteScalar();

                        cadenaComando = "SELECT RowVersion FROM Ciudades WHERE CiudadId=@id";
                        comando=new SqlCommand(cadenaComando,cn);
                        comando.Parameters.AddWithValue("@id", ciudad.CiudadId);
                        ciudad.RowVersion = (byte[]) comando.ExecuteScalar();
                    }

                    
                }

                return registrosAfectados;

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Ciudad ciudad)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "DELETE FROM Ciudades WHERE CiudadId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", ciudad.CiudadId);
                    comando.Parameters.AddWithValue("@r", ciudad.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registro relacionado... baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public int Editar(Ciudad ciudad)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "UPDATE Ciudades SET NombreCiudad=@nom, PaisId=@paisId WHERE CiudadId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", ciudad.NombreCiudad);
                    comando.Parameters.AddWithValue("@paisId", ciudad.PaisId);
                    comando.Parameters.AddWithValue("@id", ciudad.CiudadId);
                    comando.Parameters.AddWithValue("@r", ciudad.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Ciudades WHERE CiudadId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", ciudad.CiudadId);
                        ciudad.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_"))
                {
                    throw new Exception("Ciudad repetida");
                }
                throw new Exception(e.Message);
            }
        }
    }
}
