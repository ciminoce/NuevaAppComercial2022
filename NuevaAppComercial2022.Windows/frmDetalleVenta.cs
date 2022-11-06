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
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmDetalleVenta : Form
    {
        public frmDetalleVenta()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private Venta venta;
        public void SetVenta(Venta venta)
        {
            this.venta = venta;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (venta!=null)
            {
                VentaNroTextBox.Text = venta.VentaId.ToString();
                ClienteTextBox.Text = venta.Cliente.Nombre;
                FechaVtaTextBox.Text = venta.FechaVenta.ToShortDateString();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,venta.Detalles);
                TotalVtaTextBox.Text = venta.Total.ToString("C2");
            }
        }
    }
}
