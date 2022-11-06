using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class PaisesRepositorio
    {
        private SqlConnection cn;

        public PaisesRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Pais> GetLista()
        {
            List<Pais> lista = new List<Pais>();
            try
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

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
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
                var cadenaComando = "DELETE FROM Paises WHERE PaisId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                comando.Parameters.AddWithValue("@r", pais.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Pais pais)
        {
            int registrosAfectados = 0;
            try
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

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool EstaRelacionado(Pais pais)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Ciudades WHERE PaisId=@id";
                var comando=new SqlCommand(cadenaComando,cn);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                return (int) comando.ExecuteScalar()>0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Pais GetPaisPorId(int id)
        {
            try
            {
                Pais pais = null;
                var cadenaComando = "SELECT PaisId, NombrePais, RowVersion FROM Paises WHERE PaisId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        pais = ConstruirPais(reader);
                    }
                }
                return pais;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int GetCantidad()
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Paises";
                var comando = new SqlCommand(cadenaComando, cn);
                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Pais> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            List<Pais> lista = new List<Pais>();
            try
            {
                var cadenaComando = "SELECT PaisId, NombrePais, RowVersion FROM Paises ORDER BY NombrePais OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY";
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
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
            catch (Exception e)
            {
                throw new Exception("Error al leer de la tabla de Países");
            }
        }
    }
}
