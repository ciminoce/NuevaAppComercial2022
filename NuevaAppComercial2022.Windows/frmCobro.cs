using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using NuevaAppComercial2022.Entidades.Enums;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCobro : Form
    {
        public frmCobro()
        {
            InitializeComponent();
        }

        private decimal monto;
        private decimal importe;
        private FormaPago formaPago = 0;

        public void SetMonto(decimal monto)
        {
            this.monto = monto;
        }

        private void frmCobro_Load(object sender, EventArgs e)
        {
            ImporteLabel.Text = monto.ToString("N2");
        }

        private void EfectivoButton_Click(object sender, EventArgs e)
        {
            formaPago = FormaPago.Efectivo;
            var importeText = Interaction.InputBox("Ingrese el importe", "Pago en Efectivo", "0", 800, 400);
            decimal importeRecibido;
            if (!decimal.TryParse(importeText, out importeRecibido))
            {
                return;
            }
            else if (importeRecibido <= 0)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, "Importe inferior a lo que se debe pagar", "Error");
                return;
            }

            ImporteRecibidoLabel.Text = importeRecibido.ToString("N2");
            if (importeRecibido >= monto)
            {
                importe = monto;
                VueltoLabel.Text = (importeRecibido - monto).ToString("N2");

            }
            else
            {
                importe = importeRecibido;
            }

            
        }

        private void VisaButton_Click(object sender, EventArgs e)
        {
            formaPago = FormaPago.Visa;
            importe = decimal.Parse(ImporteLabel.Text);

        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (formaPago == 0)
            {
                valido = false;
                errorProvider1.SetError(ImporteLabel, "Debe seleccionar una forma de pago");
            }

            return valido;
        }

        public FormaPago GetFormaDePago()
        {
            return formaPago;
        }

        public decimal GetImportePagado()
        {
            return importe;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    };
}
