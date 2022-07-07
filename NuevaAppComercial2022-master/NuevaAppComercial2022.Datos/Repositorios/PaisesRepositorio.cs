using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class PaisesRepositorio
    {
        private readonly ConexionBd conexionBd;

        public PaisesRepositorio()
        {
            conexionBd = new ConexionBd();
        }

        public List<Pais> GetLista()
        {
            List<Pais> lista = new List<Pais>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT PaisId, NombrePais, RowVersion FROM Paises ORDER BY NombrePais";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pais = ConstruirPais(reader);
                            lista.Add(pais);
                        }

                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de Países");
            }
        }

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais()
            {
                PaisId = reader.GetInt32(0),
                NombrePais = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        public int Agregar(Pais pais)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "INSERT INTO Paises (NombrePais) VALUES (@nom)";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", pais.NombrePais);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        comando = new SqlCommand(cadenaComando, cn);
                        pais.PaisId = (int)(decimal)comando.ExecuteScalar();
                        cadenaComando = "SELECT RowVersion FROM Paises WHERE PaisId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", pais.PaisId);
                        pais.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                //if (e.Message.Contains("IX_NombrePais"))
                //{
                //    throw new Exception("País repetido");
                //}

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT COUNT(*) FROM Paises WHERE NombrePais=@nom";
                    if (pais.PaisId!=0)
                    {
                        cadenaComando += " AND PaisId<>@paisId";
                    }
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", pais.NombrePais);
                    if (pais.PaisId != 0)
                    {
                        comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                    }

                    return (int)comando.ExecuteScalar() > 0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Borrar(Pais pais)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "DELETE FROM Paises WHERE PaisId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                    comando.Parameters.AddWithValue("@r", pais.RowVersion);
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

        public int Editar(Pais pais)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "UPDATE Paises SET NombrePais=@nom WHERE PaisId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", pais.NombrePais);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                    comando.Parameters.AddWithValue("@r", pais.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Paises WHERE PaisId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", pais.PaisId);
                        pais.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                //if (e.Message.Contains("IX_NombrePais"))
                //{
                //    throw new Exception("País repetido");
                //}
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(Pais pais)
        {
            try
            {
                using (var cn=conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT COUNT(*) FROM Ciudades WHERE PaisId=@id";
                    var comando=new SqlCommand(cadenaComando,cn);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                    return (int) comando.ExecuteScalar()>0;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
