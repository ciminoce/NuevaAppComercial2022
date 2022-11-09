using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Enums;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmDetalleCtaCte : Form
    {
        public frmDetalleCtaCte()
        {
            InitializeComponent();
        }

        private List<CtaCte> lista;
        private Cliente cliente;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (lista != null)
            {
                cliente = lista[0].Cliente;
                txtCliente.Text = cliente.Nombre.ToString();
                txtDireccion.Text = $"{cliente.Direccion} ";
                //txtLocalidad.Text = cliente.Ciudad..NombreLocalidad;
                //txtProvincia.Text = cliente.Domicilio.Provincia.NombreProvincia;
                
                if (lista.Count > 0)
                {
                    MostrarDatosGrilla(lista);
                    txtSaldo.Text = lista[lista.Count - 1].Saldo.ToString("c");
                }
            }
        }

        private void MostrarDatosGrilla(List<CtaCte> lista)
        {
            dgDatos.Rows.Clear();
            foreach (var ctaCte in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgDatos);
                SetearFila(r, ctaCte);
                AgregarFila(r);
            }
        }

        private void SetearFila(DataGridViewRow r, CtaCte ctaCte)
        {
            r.Cells[cmnFecha.Index].Value = ctaCte.FechaMovimiento;
            r.Cells[cmnMovimiento.Index].Value = ctaCte.Movimiento;
            r.Cells[cmnDebe.Index].Value = ctaCte.Debe;
            r.Cells[cmnHaber.Index].Value = ctaCte.Haber;

            r.Tag = ctaCte;

        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgDatos.Rows.Add(r);
        }

        private void btnIngresarPago_Click(object sender, EventArgs e)
        {
            frmCobro frm = new frmCobro();
            frm.Text = "Ingreso de Pago";
            frm.SetMonto(decimal.Parse(txtSaldo.Text));
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                //DialogResult dr = frm.ShowDialog(this);
                //if (dr == DialogResult.Cancel)
                //{
                //    return;
                //}

                //try
                //{
                //    FormaPago forma = frm.GetFormaDePago();
                //    decimal importeRecibido = frm.GetImportePagado();
                //    servicio.Pagar(venta, forma, importeRecibido);
                //    HelperMessage.Mensaje(TipoMensaje.OK, "Pago efectuado!!!", "Operación Exitosa");
                //    HelperGrid.SetearFila(r, venta);
                //    PagarIconButton.Enabled = false;
                //}
                //catch (Exception exception)
                //{
                //    HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "ERROR");
                //    PagarIconButton.Enabled = false;
                //}

                //var ctaCte = frm.GetMovimientoCtaCte();
                //try
                //{
                //    ServicioCtaCte.GetInstancia().Agregar(ctaCte);
                //    DataGridViewRow r = new DataGridViewRow();
                //    r.CreateCells(dgDatos);
                //    SetearFila(r, ctaCte);
                //    AgregarFila(r);
                //    txtSaldo.Text = ServicioCtaCte.GetInstancia().GetSaldo(cliente).ToString("C");

                //}
                //catch (Exception ex)
                //{

                //    MessageBox.Show(ex.Message);
                //}

            }

        }


        public void SetCtaCte(List<CtaCte> movimientos)
        {
            lista = movimientos;
        }

        private void btnImprimirCtaCte_Click(object sender, EventArgs e)
        {
            HelperImprimir.ImprimirCtaCte(lista);
        }
    }
}
