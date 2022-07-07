using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class ClientesRepositorio
    {
        private ConexionBd conexionBd;

        public ClientesRepositorio()
        {
            conexionBd=new ConexionBd();
        }
        public List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT ClienteId, NombreCliente, Direccion, PaisId, CiudadId, CodPostal, RowVersion FROM Clientes";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = ConstruirCliente(reader);
                            lista.Add(cliente);
                        }

                    }

                    SetPaises(lista, cn);
                    SetCiudades(lista, cn);
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void SetCiudades(List<Cliente> lista, SqlConnection cn)
        {
            foreach (var cliente in lista)
            {
                cliente.Ciudad = SetCiudad(cliente.Ciudadid,cn);
            }
        }

        private Ciudad SetCiudad(int id, SqlConnection cn)
        {
            Ciudad ciudad = null;
            var cadenaComando = "SELECT CiudadId, NombreCiudad, PaisId, RowVersion FROM Ciudades WHERE Ciudadid=@id";
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

        private Cliente ConstruirCliente(SqlDataReader reader)
        {
            return new Cliente()
            {
                ClienteId = reader.GetInt32(0),
                NombreCliente = reader.GetString(1),
                Direccion = reader.GetString(2),
                PaisId = reader.GetInt32(3),
                Ciudadid = reader.GetInt32(4),
                CodPostal = reader[5]!=DBNull.Value? reader.GetString(5):string.Empty,
                RowVersion = (byte[]) reader[6]
            };
        }

        private void SetPaises(List<Cliente> lista, SqlConnection cn)
        {
            foreach (var cliente in lista)
            {
                cliente.Pais = SetPais(cliente.PaisId, cn);
            }
        }

        private Pais SetPais(int id, SqlConnection cn)
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

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais()
            {
                PaisId = reader.GetInt32(0),
                NombrePais = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

        private Ciudad ConstruirCiudad(SqlDataReader reader)
        {
            return new Ciudad()
            {
                CiudadId = reader.GetInt32(0),
                NombreCiudad = reader.GetString(1),
                PaisId = reader.GetInt32(2),
                RowVersion = (byte[])reader[3]

            };
        }

        //public int Agregar(Cliente cliente)
        //{
        //    int registrosAfectados = 0;
        //    try
        //    {
        //        using (var cn = conexionBd.AbrirConexion())
        //        {
        //            var cadenaComando = "INSERT INTO Clientes (NombreCliente, PaisId) VALUES(@nom , @paisId)";
        //            var comando = new SqlCommand(cadenaComando, cn);
        //            comando.Parameters.AddWithValue("@nom", cliente.NombreCliente);
        //            comando.Parameters.AddWithValue("@paisId", cliente.PaisId);
        //            registrosAfectados = comando.ExecuteNonQuery();
        //            if (registrosAfectados == 0)
        //            {
        //                throw new Exception("No se agregaron registros");
        //            }
        //            else
        //            {
        //                cadenaComando = "SELECT @@IDENTITY";
        //                comando = new SqlCommand(cadenaComando, cn);
        //                cliente.ClienteId = (int)(decimal)comando.ExecuteScalar();

        //                cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
        //                comando = new SqlCommand(cadenaComando, cn);
        //                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
        //                cliente.RowVersion = (byte[])comando.ExecuteScalar();
        //            }


        //        }

        //        return registrosAfectados;

        //    }
        //    catch (Exception e)
        //    {

        //        throw new Exception(e.Message);
        //    }
        //}

        //public int Borrar(Cliente cliente)
        //{
        //    int registrosAfectados = 0;
        //    try
        //    {
        //        using (var cn = conexionBd.AbrirConexion())
        //        {
        //            var cadenaComando = "DELETE FROM Clientes WHERE ClienteId=@id AND RowVersion=@r";
        //            var comando = new SqlCommand(cadenaComando, cn);
        //            comando.Parameters.AddWithValue("@id", cliente.ClienteId);
        //            comando.Parameters.AddWithValue("@r", cliente.RowVersion);
        //            registrosAfectados = comando.ExecuteNonQuery();
        //        }

        //        return registrosAfectados;
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.Message.Contains("REFERENCE"))
        //        {
        //            throw new Exception("Registro relacionado... baja denegada");
        //        }
        //        throw new Exception(e.Message);
        //    }
        //}

        //public int Editar(Cliente cliente)
        //{
        //    int registrosAfectados = 0;
        //    try
        //    {
        //        using (var cn = conexionBd.AbrirConexion())
        //        {
        //            var cadenaComando = "UPDATE Clientes SET NombreCliente=@nom, PaisId=@paisId WHERE ClienteId=@id AND RowVersion=@r";
        //            var comando = new SqlCommand(cadenaComando, cn);
        //            comando.Parameters.AddWithValue("@nom", cliente.NombreCliente);
        //            comando.Parameters.AddWithValue("@paisId", cliente.PaisId);
        //            comando.Parameters.AddWithValue("@id", cliente.ClienteId);
        //            comando.Parameters.AddWithValue("@r", cliente.RowVersion);
        //            registrosAfectados = comando.ExecuteNonQuery();
        //            if (registrosAfectados > 0)
        //            {
        //                cadenaComando = "SELECT RowVersion FROM Clientes WHERE ClienteId=@id";
        //                comando = new SqlCommand(cadenaComando, cn);
        //                comando.Parameters.AddWithValue("@id", cliente.ClienteId);
        //                cliente.RowVersion = (byte[])comando.ExecuteScalar();
        //            }
        //        }

        //        return registrosAfectados;
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.Message.Contains("IX_"))
        //        {
        //            throw new Exception("Cliente repetida");
        //        }
        //        throw new Exception(e.Message);
        //    }
        //}

    }
}
