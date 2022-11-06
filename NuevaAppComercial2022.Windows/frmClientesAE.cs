using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmClientesAE : Form
    {
        public frmClientesAE()
        {
            InitializeComponent();
        }

        private Cliente cliente;

        public Cliente GetCliente()
        {
            return cliente;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboPaises(ref PaisesComboBox);
            if (cliente!=null)
            {
                ClienteTextBox.Text = cliente.Nombre;
                DireccionTextBox.Text = cliente.Direccion;
                CodPostalTextBox.Text = cliente.CodPostal;
                PaisesComboBox.SelectedValue = cliente.PaisId;
                HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox,cliente.Pais);
                CiudadesComboBox.SelectedValue = cliente.CiudadId;
                FijoTextBox.Text = cliente.TelefonoFijo;
                CelularTextBox.Text = cliente.TelefonoMovil;
            }
        }

        private Pais pais;
        private void PaisesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisesComboBox.SelectedIndex > 0)
            {
                pais = (Pais)PaisesComboBox.SelectedItem;
                HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox,pais);
                AgregarCiudadIconPictureBox.Enabled = true;
            }
            else
            {
                CiudadesComboBox.DataSource = null;
                AgregarCiudadIconPictureBox.Enabled = false;
            }
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cliente==null)
                {
                    cliente = new Cliente();
                }

                cliente.Nombre = ClienteTextBox.Text;
                cliente.Direccion = DireccionTextBox.Text;
                cliente.CodPostal = CodPostalTextBox.Text;
                cliente.PaisId =(int) PaisesComboBox.SelectedValue;
                cliente.Pais = (Pais)PaisesComboBox.SelectedItem;
                cliente.CiudadId = (int)CiudadesComboBox.SelectedValue;
                cliente.Ciudad = (Ciudad)CiudadesComboBox.SelectedItem;
                cliente.TelefonoFijo = FijoTextBox.Text;
                cliente.TelefonoMovil = CelularTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ClienteTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ClienteTextBox,"El nombre del cliente es requerido");
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox,"La dirección es obligatoria");
            }

            if (string.IsNullOrEmpty(CodPostalTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(CodPostalTextBox,"El CP es requerido");
            }

            if (PaisesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisesComboBox,"Debe seleccionar un país");
            }

            if (CiudadesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CiudadesComboBox,"Debe seleccionar una ciudad");
            }

            return valido;
        }

        private void AgregarPaisIconPictureBox_Click(object sender, EventArgs e)
        {
            frmPaisesAE frm = new frmPaisesAE() { Text = "Agregar un país" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                PaisesServicios servicio = new PaisesServicios();
                Pais pais = frm.GetPais();
                if (servicio.Existe(pais))
                {
                    return;
                }
                else
                {
                    int registros = servicio.Agregar(pais);
                    HelperMessage.Mensaje(TipoMensaje.OK, "País Agregado", "Mensaje");
                    PaisesComboBox.DataSource = null;
                    HelperCombos.CargarDatosComboPaises(ref PaisesComboBox);
                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void AgregarCiudadIconPictureBox_Click(object sender, EventArgs e)
        {
            frmCiudadesAE frm = new frmCiudadesAE() { Text = "Agregar Ciudad" };
            frm.SetPais(pais);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }
            else
            {
                CiudadesServicios servicio = new CiudadesServicios();
                Ciudad ciudad = frm.GetCiudad();
                if (servicio.Existe(ciudad))
                {
                    return;
                }
                else
                {
                    servicio.Agregar(ciudad);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Ciudad Agregada!!", "Mensaje");
                    CiudadesComboBox.DataSource = null;
                    HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox, pais);
                }
            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
    }
}
