using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class ProductosRepositorio
    {
        private SqlConnection cn;
        private SqlTransaction tran;

        public ProductosRepositorio(SqlConnection cn, SqlTransaction tran)
        {
            this.cn = cn;
            this.tran = tran;
        }
        public ProductosRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Producto> GetLista(Categoria categoria=null)
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ProductoId, NombreProducto, CategoriaId, PrecioUnitario, Stock, Suspendido, UnidadesEnPedido, RowVersion FROM Productos ");
                if (categoria!=null)
                {
                    sb.Append(" WHERE Suspendido=0 AND CategoriaId=@cat ORDER BY NombreProducto");
                }
                else
                {
                    sb.Append("WHERE Suspendido=0 ORDER BY NombreProducto");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (categoria!=null)
                {
                    comando.Parameters.AddWithValue("@cat", categoria.CategoriaId);
                }
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto producto = ConstruirProducto(reader);
                        lista.Add(producto);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Producto producto)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Productos WHERE NombreProducto=@nom";
                if (producto.ProductoId != 0)
                {
                    cadenaComando += " AND ProductoId<>@prodId";
                }

                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", producto.NombreProducto);
                if (producto.ProductoId != 0)
                {
                    comando.Parameters.AddWithValue("@prodId", producto.ProductoId);
                }

                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        private Producto ConstruirProducto(SqlDataReader reader)
        {
            return new Producto()
            {
                ProductoId = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                CategoriaId = reader.GetInt32(2),
                PrecioUnitario = reader.GetDecimal(3),
                Stock = reader.GetInt32(4),
                Suspendido =reader.GetBoolean(5),
                UnidadesEnPedido = reader.GetInt32(6),
                RowVersion = (byte[])reader[7]
            };
        }




        public int Agregar(Producto producto)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("INSERT INTO Productos (NombreProducto, ProveedorId, CategoriaId, PrecioUnitario, ");
                sb.Append(" Stock, StockMinimo, Imagen, Suspendido) VALUES(@nom, @provId, @catId, @precio, @stock, @min, @img, @sus)");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", producto.NombreProducto);
                comando.Parameters.AddWithValue("@provId", producto.ProveedorId);
                comando.Parameters.AddWithValue("@catId", producto.CategoriaId);
                comando.Parameters.AddWithValue("@precio", producto.PrecioUnitario);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@min", producto.StockMinimo);
                comando.Parameters.AddWithValue("@img", producto.Imagen);
                comando.Parameters.AddWithValue("@sus", producto.Suspendido);


                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se agregaron registros");
                }
                else
                {
                    cadenaComando = "SELECT @@IDENTITY";
                    comando = new SqlCommand(cadenaComando, cn);
                    producto.ProductoId = (int)(decimal)comando.ExecuteScalar();

                    cadenaComando = "SELECT RowVersion FROM Productos WHERE ProductoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", producto.ProductoId);
                    producto.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EstaRelacionado(Producto producto)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM DetalleVentas WHERE ProductoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", producto.ProductoId);
                return (int)comando.ExecuteScalar() > 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Producto producto)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Productos WHERE ProductoId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", producto.ProductoId);
                comando.Parameters.AddWithValue("@r", producto.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Producto producto)
        {
            int registrosAfectados = 0;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Productos SET NombreProducto=@nom, ProveedorId=@provId, CategoriaId=@catId, PrecioUnitario=@precio, ");
                sb.Append(" Stock=@stock, StockMinimo=@min, Imagen=@img, Suspendido=@sus ");
                sb.Append(" WHERE ProductoId=@id");

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@nom", producto.NombreProducto);
                comando.Parameters.AddWithValue("@provId", producto.ProveedorId);
                comando.Parameters.AddWithValue("@catId", producto.CategoriaId);
                comando.Parameters.AddWithValue("@precio", producto.PrecioUnitario);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@min", producto.StockMinimo);
                comando.Parameters.AddWithValue("@img", producto.Imagen);
                comando.Parameters.AddWithValue("@sus", producto.Suspendido);
                comando.Parameters.AddWithValue("@id", producto.ProductoId);
                registrosAfectados = comando.ExecuteNonQuery();
                if (registrosAfectados == 0)
                {
                    throw new Exception("No se editaron registros");
                }
                else
                {

                    cadenaComando = "SELECT RowVersion FROM Productos WHERE ProductoId=@id";
                    comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", producto.ProductoId);
                    producto.RowVersion = (byte[])comando.ExecuteScalar();
                }

                return registrosAfectados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> GetListaPaginada(int paginaActual, int registrosPorPagina, Categoria categoria = null)
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT ProductoId, NombreProducto, CategoriaId, PrecioUnitario, Stock, Suspendido, RowVersion FROM Productos ");
                

                if (categoria != null )
                {
                    sb.Append(" WHERE CategoriaId=@catId ORDER BY NombreProducto OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                }
                else
                {
                    sb.Append("ORDER BY NombreProducto OFFSET @ig ROWS FETCH NEXT @rows ROWS ONLY");
                    
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                var ignorados = registrosPorPagina * (paginaActual - 1);
                comando.Parameters.AddWithValue("@ig", ignorados);
                comando.Parameters.AddWithValue("@rows", registrosPorPagina);
                if (categoria != null)
                {
                    comando.Parameters.AddWithValue("@catId",categoria.CategoriaId);
                }

                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var producto = ConstruirProducto(reader);
                        lista.Add(producto);
                    }

                }

                return lista;
            }
            catch (Exception )
            {
                throw new Exception("Error al leer de la tabla de Productos");
            }

        }

        public int GetCantidad(Categoria categoria = null)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT COUNT(*) FROM Productos");
                if (categoria != null)
                {
                    sb.Append(" WHERE CategoriaId=@catId ");
                }

                var cadenaComando = sb.ToString();
                var comando = new SqlCommand(cadenaComando, cn);
                if (categoria != null)
                {
                    comando.Parameters.AddWithValue("@catId", categoria.CategoriaId);
                }

                return (int)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Producto GetProductoPorId(int id)
        {
            Producto producto = null;
            try
            {
                var cadenaComando =
                    "SELECT ProductoId, NombreProducto, ProveedorId, CategoriaId, PrecioUnitario, Stock, StockMinimo, Suspendido, Imagen, UnidadesEnPedido, RowVersion FROM Productos WHERE ProductoId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        producto = ConstruirProductoDetalle(reader);
                        
                    }
                }

                return producto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        private Producto ConstruirProductoDetalle(SqlDataReader reader)
        {
            return new Producto()
            {
                ProductoId = reader.GetInt32(0),
                NombreProducto = reader.GetString(1),
                ProveedorId = reader.GetInt32(2),
                CategoriaId = reader.GetInt32(3),
                PrecioUnitario = reader.GetDecimal(4),
                Stock = reader.GetInt32(5),
                StockMinimo = reader.GetInt32(6),
                Suspendido = reader.GetBoolean(7),
                Imagen = reader[8]==DBNull.Value?string.Empty:reader.GetString(8),
                UnidadesEnPedido = reader.GetInt32(9),
                RowVersion = (byte[])reader[10]
            };
        }

        public void ActualizarUnidadesEnPedido(int productoId, int cantidad)
        {
            try
            {
                string cadenaComando = "UPDATE Productos SET UnidadesEnPedido=UnidadesEnPedido+@cant WHERE ProductoId=@id";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", productoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al actualizar el stock de un producto");
            }

        }
        public void ActualizarStock(int productoId, int cantidad)
        {
            try
            {
                string cadenaComando = "UPDATE Productos SET Stock=Stock-@cant WHERE ProductoId=@id";
                var comando = new SqlCommand(cadenaComando, cn, tran);
                comando.Parameters.AddWithValue("@cant", cantidad);
                comando.Parameters.AddWithValue("@id", productoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al actualizar el stock de un producto");
            }
        }

    }
}
