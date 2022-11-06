using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Enums;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class VentasRepositorio
    {
        private SqlConnection cn;
        private SqlTransaction tran;

        public VentasRepositorio(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;
        }

        public VentasRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Venta> GetLista()
        {
            List<Venta> lista = new List<Venta>();
            try
            {
                var cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Total,  Estado, RowVersion FROM Ventas ORDER BY FechaVenta";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
                        }

                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private Venta ConstruirVenta(SqlDataReader reader)
        {
            return new Venta()
            {
                VentaId = reader.GetInt32(0),
                ClienteId = reader.GetInt32(1),
                FechaVenta = reader.GetDateTime(2),
                Total=reader.GetDecimal(3),
                Estado=(Estado)reader.GetInt32(4),
                RowVersion = (byte[])reader[5]
            };
        }

        public void Guardar(Venta venta)
        {
            try
            {
                string cadenaComando = "INSERT INTO Ventas (ClienteId, FechaVenta, Total, Estado) " +
                                       "VALUES (@clienteId, @fecha, @total, @estado)";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@clienteId", venta.ClienteId);
                comando.Parameters.AddWithValue("@fecha", venta.FechaVenta);
                comando.Parameters.AddWithValue("@total", venta.Total);

                comando.Parameters.AddWithValue("@estado", venta.Estado);

                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, cn, tran);
                int id = (int)(decimal)comando.ExecuteScalar();
                venta.VentaId = id;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Venta> GetLista(DateTime fechaBuscar)
        {
            List<Venta> lista = new List<Venta>();
            try
            {
                var cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Total, Estado, RowVersion FROM Ventas WHERE CAST(CAST(FechaVenta as date) AS datetime)=@fecha";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@fecha", fechaBuscar);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
                        }

                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Venta> GetLista(Cliente cliente)
        {
            List<Venta> lista = new List<Venta>();
            try
            {
                var cadenaComando = "SELECT VentaId, ClienteId, FechaVenta, Total,  Estado, RowVersion FROM Ventas WHERE ClienteId=@cliente ORDER BY FechaVenta";
                using (var comando = new SqlCommand(cadenaComando, cn))
                {
                    comando.Parameters.AddWithValue("@cliente", cliente.Id);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var venta = ConstruirVenta(reader);
                            lista.Add(venta);
                        }

                    }

                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Editar(Venta venta)
        {
            try
            {
                var cadenaComando = "UPDATE Ventas SET Estado=@estado WHERE VentaId=@id";
                using (var comando = new SqlCommand(cadenaComando, cn,tran))
                {
                    comando.Parameters.AddWithValue("@estado", venta.Estado);
                    comando.Parameters.AddWithValue("@id", venta.VentaId);
                    comando.ExecuteNonQuery();

                }

            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}
