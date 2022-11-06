using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class ClientesRepositorio
    {
        private SqlConnection cn;

        public ClientesRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                var cadenaComando =
                    "SELECT ClienteId, NombreCliente, Direccion, PaisId, CiudadId, CodPostal, TelFijo, TelMovil, RowVersion FROM Clientes ORDER BY NombreCliente";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = ConstruirCliente(reader);
                        lista.Add(cliente);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Clientes WHERE NombreCliente=@nom";
                if (cliente.Id != 0)
                {
                    cadenaComando += " AND ClienteId<>@clienteId";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.Nombre);
                if (cliente.Id != 0)
                {
                    comando.Parameters.AddWithValue("@clienteId", cliente.Id);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private Cliente ConstruirCliente(SqlDataReader reader)
        {
            return new Cliente()
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Direccion = reader.GetString(2),
                PaisId = reader.GetInt32(3),
                CiudadId = reader.GetInt32(4),
                CodPostal = reader[5] != DBNull.Value ? reader.GetString(5) : string.Empty,
                TelefonoFijo = reader[6] != DBNull.Value ? reader.GetString(6) : string.Empty,
                TelefonoMovil = reader[7] != DBNull.Value ? reader.GetString(7) : string.Empty,


                RowVersion = (byte[])reader[8]
            };
        }




        public int Agregar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Clientes (NombreCliente, Direccion, PaisId, CiudadId, ");
                sb.Append(" CodPostal, TelFijo, TelMovil) VALUES(@nom, @dir, @paisId, @ciudadId, @cp, @tel, @cel)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.Nombre);
                comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                comando.Parameters.AddWithValue("@paisId", cliente.PaisId);
                comando.Parameters.AddWithValue("@ciudadId", cliente.CiudadId);
                comando.Parameters.AddWithValue("@cp", cliente.CodPostal);
                if (string.IsNullOrEmpty(cliente.TelefonoFijo))
                {
                    comando.Parameters.AddWithValue("@tel", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@tel", cliente.TelefonoFijo);
                }
                if (string.IsNullOrEmpty(cliente.TelefonoMovil))
                {
                    comando.Parameters.AddWithValue("@cel", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@cel", cliente.TelefonoMovil);
                }

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    cliente.Id = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    cliente.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Ventas WHERE ClienteId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", cliente.Id);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Clientes WHERE ClienteId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", cliente.Id);
                comando.Parameters.AddWithValue("@r", cliente.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Cliente cliente)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Clientes SET NombreCliente=@nom, Direccion=@dir, PaisId=@paisId, CiudadId=@ciudadId, ");
                sb.Append(" CodPostal=@cp, TelFijo=@tel, TelMovil=@cel ");
                sb.Append(" WHERE ClienteId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", cliente.Nombre);
                comando.Parameters.AddWithValue("@dir", cliente.Direccion);
                comando.Parameters.AddWithValue("@paisId", cliente.PaisId);
                comando.Parameters.AddWithValue("@ciudadId", cliente.CiudadId);
                comando.Parameters.AddWithValue("@cp", cliente.CodPostal);
                if (string.IsNullOrEmpty(cliente.TelefonoFijo))
                {
                    comando.Parameters.AddWithValue("@tel", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@tel", cliente.TelefonoFijo);
                }
                if (string.IsNullOrEmpty(cliente.TelefonoMovil))
                {
                    comando.Parameters.AddWithValue("@cel", DBNull.Value);
                }
                else
                {
                    comando.Parameters.AddWithValue("@cel", cliente.TelefonoMovil);
                }

                comando.Parameters.AddWithValue("@id", cliente.Id);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {

                    cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", cliente.Id);
                    cliente.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cliente> GetListaPaginada(int paginaActual, int registrosPorPagina, Pais pais=null, Ciudad ciudad=null)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ClienteId, NombreCliente, Direccion, PaisId, CiudadId, CodPostal, TelFijo, TelMovil, RowVersion FROM Clientes ");
                    
                if (pais != null && ciudad==null)
                {
                    sb.Append(" WHERE PaisId=@paisId ORDER BY NombreCliente OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                }
                if(pais!=null &&  ciudad!=null)
                {
                    sb.Append(" WHERE PaisId=@paisId  AND CiudadId=@ciudadId ORDER BY NombreCliente OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                }

                if (pais==null && ciudad==null)
                {
                    sb.Append("ORDER BY NombreCliente  OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");

                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                if (pais != null)
                {
                    comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                }
                if (ciudad != null)
                {
                    comando.Parameters.AddWithValue("@ciudadId", ciudad.CiudadId);
                }

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = ConstruirCliente(reader);
                        lista.Add(cliente);
                    }

                }

                return lista;
            }
            catch (Exception )
            {
                throw new Exception("Error al leer de la tabla de Clientes");
            }

        }

        public int GetCantidad(Pais pais=null, Ciudad ciudad=null)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Clientes");
                if (pais != null)
                {
                    sb.Append(" WHERE PaisId=@paisId ");
                }
                if (ciudad != null)
                {
                    sb.Append("AND CiudadId=@ciudadId");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (pais != null)
                {
                    comando.Parameters.AddWithValue("@paisId", pais.PaisId);
                }
                if (ciudad != null)
                {
                    comando.Parameters.AddWithValue("@ciudadId", ciudad.CiudadId);
                }

                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            Cliente cliente = null;
            try
            {
                var cadenaComando =
                    "SELECT ClienteId, NombreCliente, Direccion, PaisId, CiudadId, CodPostal, TelFijo, TelMovil, RowVersion FROM Clientes WHERE ClienteId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader=comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            cliente = ConstruirCliente(reader);
                        }
                    }

                }

                return cliente;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}