using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Windows.Class;

namespace NuevaAppComercial2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r=new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Pais p:
                    r.Cells[0].Value = p.NombrePais;

                    break;
                case Categoria c:
                    r.Cells[0].Value = c.NombreCategoria;
                    r.Cells[1].Value = c.Descripcion;

                    break;
                case Ciudad ciudad:
                    r.Cells[0].Value = ciudad.Pais.NombrePais;
                    r.Cells[1].Value = ciudad.NombreCiudad;

                    break;
                case Persona persona:
                    r.Cells[0].Value = persona.Nombre;
                    r.Cells[1].Value = persona.Direccion;
                    r.Cells[2].Value = persona.Pais.NombrePais;
                    r.Cells[3].Value = persona.Ciudad.NombreCiudad;
                    r.Cells[4].Value = persona.CodPostal;

                    break;
                case Producto producto:
                    r.Cells[0].Value = producto.NombreProducto;
                    r.Cells[1].Value = producto.Categoria.NombreCategoria;
                    r.Cells[2].Value = producto.PrecioUnitario;
                    r.Cells[3].Value = producto.Stock;
                    r.Cells[4].Value = producto.Suspendido;
                    break;
                case Venta venta:
                    r.Cells[0].Value = venta.VentaId;
                    r.Cells[1].Value = venta.Cliente.Nombre;
                    r.Cells[2].Value = venta.FechaVenta.ToShortDateString();
                    r.Cells[3].Value = venta.Total.ToString("c2");
                    r.Cells[4].Value = venta.Estado.ToString();
                    break;

                case DetalleVenta detalle:
                    r.Cells[0].Value = detalle.Producto.NombreProducto;
                    r.Cells[1].Value = detalle.Cantidad;
                    r.Cells[2].Value = detalle.PrecioUnitario;
                    r.Cells[3].Value = detalle.Cantidad * detalle.PrecioUnitario;
                    break;

                case ItemCarrito item:
                    r.Cells[0].Value = item.Descripcion;
                    r.Cells[1].Value = item.Precio;
                    r.Cells[2].Value = item.Cantidad;
                    r.Cells[3].Value = item.Cantidad * item.Precio;
                    break;

            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
    }
}
