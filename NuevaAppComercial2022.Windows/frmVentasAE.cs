using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Enums;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Class;
using NuevaAppComercial2022.Windows.Helpers;
using NuevaAppComercial2022.Windows.UserControls;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmVentasAE : Form
    {
        public frmVentasAE()
        {
            InitializeComponent();
        }

        private ProductosServicios servicioProducto = new ProductosServicios();
        private List<Producto> lista;

        public void SetLista(List<Producto> lista)
        {
            this.lista = lista;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboCategorias(ref CategoriasComboBox);
            MostrarProductosEnLayout();
        }

        private void MostrarProductosEnLayout()
        {
            ProductoFlowLayoutPanel.Controls.Clear();
            foreach (var producto in lista)
            {
                ucProducto ucProducto = new ucProducto()
                {
                    ProductoId = producto.ProductoId,
                    Descripcion = producto.NombreProducto,
                    Precio = producto.PrecioUnitario.ToString("C"),
                    Stock = $"Unidades: {producto.UnidadesDisponibles().ToString()}",
                    Imagen = producto.Imagen

                };
                if (producto.UnidadesDisponibles() == 0)
                {
                    ucProducto.Enabled = false;
                    ucProducto.BackColor = Color.Yellow;
                }

                ucProducto.Name = producto.ProductoId.ToString();
                ucProducto.AgregarButton.Tag = producto.ProductoId;
                ucProducto.AgregarButton.Click += AgregarButton_Click;

                ProductoFlowLayoutPanel.Controls.Add(ucProducto);
            }
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            var productoId = (int)((Button)sender).Tag;
            var producto = servicioProducto.GetProductoPorId(productoId);
            //InputBox
            var cantidadTexto =
                Microsoft.VisualBasic.Interaction.InputBox("Ingrese la cantidad:", "Cantidad", "1", 400, 400);
            if (!int.TryParse(cantidadTexto, out int cantidad))
            {
                HelperMessage.Mensaje(TipoMensaje.Error, "Cantidad mal ingresada!!!", "Error");

                return;
            }
            else if (cantidad > producto.UnidadesDisponibles())
            {
                HelperMessage.Mensaje(TipoMensaje.Warning, "Stock insuficiente!!!", "Advertencia");
                return;
            }


            //


            var itemCarrito = new ItemCarrito()
            {
                ProductoId = producto.ProductoId,
                Descripcion = producto.NombreProducto,
                Precio = producto.PrecioUnitario,
                Cantidad = cantidad

            };
            Carrito.GetInstancia().Agregar(itemCarrito);
            servicioProducto.ActualizarUnidadesEnPedido(producto.ProductoId, cantidad);

            HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().GetItems());
            MostrarTotalesCarrito();
            producto = servicioProducto.GetProductoPorId(productoId);

            ucProducto ucSeleccionado =
                (ucProducto)ProductoFlowLayoutPanel.Controls.Find(productoId.ToString(), true)[0];
            ucSeleccionado.Stock = $"Unidades: {producto.UnidadesDisponibles().ToString()}";
            ((ucProducto)ProductoFlowLayoutPanel.Controls.Find(producto.ProductoId.ToString(), true)[0]).StockLabel
                .Text = $"Unidades: {producto.UnidadesDisponibles().ToString()}";
            if (producto.UnidadesDisponibles() == 0)
            {
                ucSeleccionado.Enabled = false;
                ucSeleccionado.BackColor = Color.Yellow;
            }

        }

        private void MostrarTotalesCarrito()
        {
            CantidadLabel.Text = Carrito.GetInstancia().GetCantidad().ToString();
            TotalLabel.Text = Carrito.GetInstancia().GetTotal().ToString("C");
        }

        private void ProductoFlowLayoutPanel_MouseEnter(object sender, EventArgs e)
        {

        }

        private Categoria categoria = null;

        private void CategoriasComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CategoriasComboBox.SelectedIndex > 0)
            {
                categoria = (Categoria)CategoriasComboBox.SelectedItem;
            }
            else
            {
                categoria = null;
            }

            lista = servicioProducto.GetLista(categoria);
            MostrarProductosEnLayout();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            //Restauro las cantidades de UnidadesEnPedido
            foreach (var itemCarrito in Carrito.GetInstancia().GetItems())
            {
                servicioProducto.ActualizarUnidadesEnPedido(itemCarrito.ProductoId, -itemCarrito.Cantidad);
            }

            Carrito.GetInstancia().LimpiarCarrito(); //Vacío el carrito
            DialogResult = DialogResult.Cancel;

        }

        private Venta venta;
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (Carrito.GetInstancia().GetCantidad() == 0)
            {
                return;
            }

            frmSeleccionarCliente frm = new frmSeleccionarCliente();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            Cliente cliente = frm.GetCliente();
            venta = new Venta()
            {
                ClienteId = cliente.Id,
                FechaVenta = DateTime.Now,
                Estado = Estado.Impaga,
                Total=Carrito.GetInstancia().GetTotal(),
                Detalles = CargarDetalles()
            };
            DialogResult = DialogResult.OK;

        }
        private List<DetalleVenta> CargarDetalles()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            foreach (var itemCarrito in Carrito.GetInstancia().GetItems())
            {
                var detalle = new DetalleVenta()
                {
                    ProductoId = itemCarrito.ProductoId,
                    PrecioUnitario = itemCarrito.Precio,
                    Cantidad = itemCarrito.Cantidad,
                };
                lista.Add(detalle);
            }

            return lista;
        }

        public Venta GetVenta()
        {
            return venta;
        }

        private void CarritoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4)
            {
                var r = CarritoDataGridView.SelectedRows[0];
                ItemCarrito item=r.Tag as ItemCarrito;
                Carrito.GetInstancia().QuitarItem(item);
                HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().GetItems());
                servicioProducto.ActualizarUnidadesEnPedido(item.ProductoId,-item.Cantidad);
                MostrarTotalesCarrito();

                var producto = servicioProducto.GetProductoPorId(item.ProductoId);

                ucProducto ucSeleccionado =
                    (ucProducto)ProductoFlowLayoutPanel.Controls.Find(producto.ProductoId.ToString(), true)[0];
                ucSeleccionado.Stock = $"Unidades: {producto.UnidadesDisponibles().ToString()}";
                ((ucProducto)ProductoFlowLayoutPanel.Controls.Find(producto.ProductoId.ToString(), true)[0]).StockLabel
                    .Text = $"Unidades: {producto.UnidadesDisponibles().ToString()}";
                if (producto.UnidadesDisponibles() == 0)
                {
                    ucSeleccionado.Enabled = false;
                    ucSeleccionado.BackColor = Color.Yellow;
                }

            }
        }
    }
}
