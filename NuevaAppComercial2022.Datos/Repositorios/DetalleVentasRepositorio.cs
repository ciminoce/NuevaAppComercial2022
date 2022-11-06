using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class DetalleVentasRepositorio
    {
        private readonly SqlConnection cn;
        private readonly SqlTransaction tran;

        public DetalleVentasRepositorio(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;
        }

        public DetalleVentasRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<DetalleVenta> GetDetalleVentas(int id)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            try
            {
                var cadenaComando =
                    "SELECT DetalleVentaId, ProductoId, PrecioUnitario, Cantidad, RowVersion FROM DetalleVentas WHERE VentaId=@id";
                using (var comando=new SqlCommand(cadenaComando,cn))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    using (var reader=comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var detalle = ConstruirDetalle(reader);
                            lista.Add(detalle);
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

        private DetalleVenta ConstruirDetalle(SqlDataReader reader)
        {
            return new DetalleVenta()
            {
                DetalleVentaId = reader.GetInt32(0),
                ProductoId = reader.GetInt32(1),
                PrecioUnitario = reader.GetDecimal(2),
                Cantidad = reader.GetInt32(3),
                RowVersion = (byte[])reader[4]
            };
        }

        public void Guardar(DetalleVenta detalle)
        {
            try
            {
                string cadenaComando = "INSERT INTO DetalleVentas (VentaId,ProductoId, PrecioUnitario, Cantidad) " +
                                       "VALUES (@vta, @prod, @pUnit, @cant)";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@vta", detalle.VentaId);
                comando.Parameters.AddWithValue("@prod", detalle.ProductoId);
                comando.Parameters.AddWithValue("@pUnit", detalle.PrecioUnitario);
                comando.Parameters.AddWithValue("@cant", detalle.Cantidad);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar guardar un detalle de venta");
            }
        }
    }
}
