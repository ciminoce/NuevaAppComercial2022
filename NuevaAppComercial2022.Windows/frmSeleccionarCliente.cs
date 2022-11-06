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
    public partial class frmSeleccionarCliente : Form
    {
        public frmSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Cliente cliente;
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboClientes(ref ClienteComboBox);

        }

        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClienteComboBox.SelectedIndex>0)
            {
                cliente = (Cliente) ClienteComboBox.SelectedItem;
                MostrarDatosCliente();
            }
            else
            {
                cliente = null;
            }
        }

        private void MostrarDatosCliente()
        {
            DireccionTextBox.Text = cliente.Direccion;
        }

        public Cliente GetCliente()
        {
            return cliente;
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
            return true;
        }
    }
}
