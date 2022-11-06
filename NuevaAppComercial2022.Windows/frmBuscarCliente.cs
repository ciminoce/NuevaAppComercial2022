using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        private Cliente cliente;
        private List<Cliente> lista;
        private List<Cliente> listaFiltrada;
        private ClientesServicios servicio;
        private void ClienteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ClienteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ClienteTextBox.Text.Length>0)
            {
                listaFiltrada = lista.Where(c => c.Nombre.StartsWith(ClienteTextBox.Text)).ToList();

            }
            else
            {
                listaFiltrada = lista;
            }
            HelperForm.MostrarDatosEnGrilla(DatosDataGridView, listaFiltrada);

        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            servicio = new ClientesServicios();
            lista = servicio.GetLista();
            HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
        }

        public Cliente GetCliente()
        {
            return cliente;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
            if (cliente==null)
            {
                errorProvider1.SetError(ClienteTextBox,"Debe seleccionar un cliente");
                valido = false;
            }

            return valido;
        }

        private void DatosDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow r = DatosDataGridView.SelectedRows[0];
                cliente = (Cliente)r.Tag;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void DatosDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = DatosDataGridView.SelectedRows[0];
            cliente = (Cliente)r.Tag;

        }
    }
}
