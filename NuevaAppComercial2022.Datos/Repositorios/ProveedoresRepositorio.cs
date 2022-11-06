using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class ProveedoresRepositorio
    {
        private SqlConnection cn;

        public ProveedoresRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Proveedor> GetLista()
        {
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                var cadenaComando =
                    "SELECT ProveedorId, RazonSocial, Direccion, PaisId, CiudadId, CodPostal, RowVersion FROM Proveedores ORDER BY RazonSocial";
                var comando = new SqlCommand(cadenaComando, cn);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Proveedor proveedor = ConstruirProveedor(reader);
                        lista.Add(proveedor);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Proveedores WHERE RazonSocial=@nom";
                if (proveedor.Id != 0)
                {
                    cadenaComando += " AND ProveedorId<>@proveedorId";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", proveedor.Nombre);
                if (proveedor.Id != 0)
                {
                    comando.Parameters.AddWithValue("@proveedorId", proveedor.Id);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private Proveedor ConstruirProveedor(SqlDataReader reader)
        {
            return new Proveedor()
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Direccion = reader.GetString(2),
                PaisId = reader.GetInt32(3),
                CiudadId = reader.GetInt32(4),
                CodPostal = reader[5] != DBNull.Value ? reader.GetString(5) : string.Empty,
                RowVersion = (byte[])reader[6]
            };
        }




        //public int Borrar(Proveedor proveedor)
        //{
        //    int registrosAfectados = 0;
        //    try
        //    {
        //        using (var cn = conexionBd.AbrirConexion())
        //        {
        //            var cadenaComando = "DELETE FROM Proveedores WHERE ProveedorId=@id AND RowVersion=@r";
        //            var comando = new SqlCommand(cadenaComando, cn);
        //            comando.Parameters.AddWithValue("@id", proveedor.ProveedorId);
        //            comando.Parameters.AddWithValue("@r", proveedor.RowVersion);
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

        //public int Editar(Proveedor proveedor)
        //{
        //    int registrosAfectados = 0;
        //    try
        //    {
        //        using (var cn = conexionBd.AbrirConexion())
        //        {
        //            var cadenaComando = "UPDATE Proveedores SET RazonSocial=@nom, PaisId=@paisId WHERE ProveedorId=@id AND RowVersion=@r";
        //            var comando = new SqlCommand(cadenaComando, cn);
        //            comando.Parameters.AddWithValue("@nom", proveedor.RazonSocial);
        //            comando.Parameters.AddWithValue("@paisId", proveedor.PaisId);
        //            comando.Parameters.AddWithValue("@id", proveedor.ProveedorId);
        //            comando.Parameters.AddWithValue("@r", proveedor.RowVersion);
        //            registrosAfectados = comando.ExecuteNonQuery();
        //            if (registrosAfectados > 0)
        //            {
        //                cadenaComando = "SELECT RowVersion FROM Proveedores WHERE ProveedorId=@id";
        //                comando = new SqlCommand(cadenaComando, cn);
        //                comando.Parameters.AddWithValue("@id", proveedor.ProveedorId);
        //                proveedor.RowVersion = (byte[])comando.ExecuteScalar();
        //            }
        //        }

        //        return registrosAfectados;
        //    }
        //    catch (Exception e)
        //    {
        //        if (e.Message.Contains("IX_"))
        //        {
        //            throw new Exception("Proveedor repetida");
        //        }
        //        throw new Exception(e.Message);
        //    }
        //}

        public int Agregar(Proveedor proveedor)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Proveedores (RazonSocial, Direccion, PaisId, CiudadId, ");
                sb.Append(" CodPostal) VALUES(@nom, @dir, @paisId, @ciudadId, @cp)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", proveedor.Nombre);
                comando.Parameters.AddWithValue("@dir", proveedor.Direccion);
                comando.Parameters.AddWithValue("@paisId", proveedor.PaisId);
                comando.Parameters.AddWithValue("@ciudadId", proveedor.CiudadId);
                comando.Parameters.AddWithValue("@cp", proveedor.CodPostal);

                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    proveedor.Id = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Proveedores WHERE ProveedorId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", proveedor.Id);
                    proveedor.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Ventas WHERE ProveedorId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", proveedor.Id);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Proveedor proveedor)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Proveedores WHERE ProveedorId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", proveedor.Id);
                comando.Parameters.AddWithValue("@r", proveedor.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
