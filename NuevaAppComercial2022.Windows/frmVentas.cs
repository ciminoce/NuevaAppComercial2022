using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Enums;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private VentasServicios servicio;
        private ProductosServicios servicioProducto;
        private List<Venta> lista;
        private Venta venta;
        private DataGridViewRow r;
        private void frmVentas_Load(object sender, EventArgs e)
        {
            servicio = new VentasServicios();
            servicioProducto = new ProductosServicios();
            
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            try
            {
                r = DatosDataGridView.SelectedRows[0];
                venta = (Venta)r.Tag;
                venta.Detalles = servicio.GetDetalleVenta(venta.VentaId);
                frmDetalleVenta frm = new frmDetalleVenta() { Text = "Detalle de la Venta" };
                frm.SetVenta(venta);
                frm.ShowDialog(this);

            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
            }
        }

        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleIconButton.Enabled = true;
            r = DatosDataGridView.SelectedRows[0];
            venta = r.Tag as Venta;
            if (venta.Estado == Estado.Impaga)
            {
                PagarIconButton.Enabled = true;
            }
            else
            {
                PagarIconButton.Enabled = false;
            }

        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmVentasAE frm = new frmVentasAE() { Text = "Nueva Venta" };

            frm.SetLista(servicioProducto.GetLista());
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                HelperMessage.Mensaje(TipoMensaje.Exclamation, "Venta cancelada por usuario!!!", "Advertencia");
                return;//faltó poner esto la clase pasada
            }
            try
            {
                venta = frm.GetVenta();
                servicio.Guardar(venta);
                RecargarGrilla();
                HelperMessage.Mensaje(TipoMensaje.OK, "Venta Guardada", "Mensaje");

            }
            catch (Exception ex)
            {

                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }


        }

        private void FiltroIconButton_Click(object sender, EventArgs e)
        {
            frmBuscarFecha frm = new frmBuscarFecha() {Text = "Seleccione fecha a filtrar"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            DateTime fechaBuscar = frm.GetFecha();
            try
            {
                lista = servicio.GetLista(fechaBuscar);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void FiltroClienteIconButton_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente() {Text = "Seleccione Cliente a Filtrar"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                var cliente = frm.GetCliente();
                lista = servicio.GetLista(cliente);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
            }
        }

        private void PagarIconButton_Click(object sender, EventArgs e)
        {
            frmCobro frm = new frmCobro() {Text = "Pago del Cliente"};
            frm.SetMonto(venta.Total);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                FormaPago forma = frm.GetFormaDePago();
                decimal importeRecibido = frm.GetImportePagado();
                servicio.Pagar(venta,forma, importeRecibido);
                HelperMessage.Mensaje(TipoMensaje.OK, "Pago efectuado!!!", "Operación Exitosa");
                HelperGrid.SetearFila(r,venta);
                PagarIconButton.Enabled = false;
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
                PagarIconButton.Enabled = false;
            }
        }

        private void DatosDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DetalleIconButton.Enabled = true;
            r = DatosDataGridView.SelectedRows[0];
            venta = r.Tag as Venta;
            if (venta.Estado==Estado.Impaga)
            {
                PagarIconButton.Enabled = true;
            }
            else
            {
                PagarIconButton.Enabled = false;
            }
        }

        private void ActualizarIconButton_Click(object sender, EventArgs e)
        {
            try
            {
                RecargarGrilla();
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
            }
        }
    }
}
