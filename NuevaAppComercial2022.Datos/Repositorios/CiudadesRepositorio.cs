using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class CiudadesRepositorio
    {
        private SqlConnection cn;

        public CiudadesRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public Ciudad GetCiudadPorId(int id)
        {
            try
            {
                Ciudad ciudad = null;
                var cadenaComando = "SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades  WHERE Ciudadid=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        ciudad = ConstruirCiudad(reader);
                    }
                }

                return ciudad;
            }
            catch (Exception e)
            {

                throw e;
            }

        }
        //public List<Ciudad> GetLista()
        //{
        //    List<Ciudad>lista=new List<Ciudad>();
        //    try
        //    {
        //        var cadenaComando = "SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades ORDER BY NombreCiudad";
        //        var comando = new SqlCommand(cadenaComando, cn);
        //        using (var reader=comando.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                Ciudad ciudad = ConstruirCiudad(reader);
        //                lista.Add(ciudad);
        //            }

        //        }


        //        return lista;
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

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
                return registrosAfectados;

            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public List<Ciudad> GetLista(Pais pais=null)
        {
            List<Ciudad> lista = new List<Ciudad>();
            try
            {
                StringBuilder sb =
                    new StringBuilder("SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades ");
                if (pais!=null)
                {
                    sb.Append("WHERE PaisId=@id ORDER BY NombreCiudad");
                }
                else
                {
                    sb.Append(" ORDER BY NombreCiudad");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (pais!=null)
                {
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ciudad ciudad = ConstruirCiudad(reader);
                        lista.Add(ciudad);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Ciudad ciudad)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Ciudades WHERE NombreCiudad=@nom AND PaisId=@paisId" ;
                if (ciudad.CiudadId != 0)
                {
                    cadenaComando += " AND CiudadId<>@ciudadId";
                }
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", ciudad.NombreCiudad);
                comando.Parameters.AddWithValue("@paisId", ciudad.PaisId);

                if (ciudad.CiudadId != 0)
                {
                    comando.Parameters.AddWithValue("@ciudadId", ciudad.CiudadId);
                }

                return (int)comando.ExecuteScalar() > 0;
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
                var cadenaComando = "DELETE FROM Ciudades WHERE CiudadId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", ciudad.CiudadId);
                comando.Parameters.AddWithValue("@r", ciudad.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Ciudad ciudad)
        {
            int registrosAfectados = 0;
            try
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

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(Pais pais=null)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Ciudades");
                if (pais!=null)
                {
                    sb.Append(" WHERE PaisId=@paisId");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (pais!=null)
                {
                    comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                }
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Ciudad> GetListaPaginada(int paginaActual, int registrosPorPagina, Pais pais=null)
        {
            List<Ciudad> lista = new List<Ciudad>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades ");
                if (pais!=null)
                {
                    sb.Append("WHERE PaisId=@paisId ORDER BY NombreCiudad OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                }
                else
                {
                    sb.Append(" ORDER BY NombreCiudad OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                if (pais!=null)
                {
                    comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ciudad = ConstruirCiudad(reader);
                        lista.Add(ciudad);
                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de Países");
            }
        }
    }
}
