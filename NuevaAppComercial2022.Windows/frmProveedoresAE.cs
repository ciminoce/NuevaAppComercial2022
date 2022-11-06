using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmProveedoresAE : Form
    {
        public frmProveedoresAE()
        {
            InitializeComponent();
        }

        private Proveedor proveedor;
        public Proveedor GetProveedor()
        {
            return proveedor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboPaises(ref PaisesComboBox);
            if (proveedor != null)
            {
                ProveedorTextBox.Text = proveedor.Nombre;
                DireccionTextBox.Text = proveedor.Direccion;
                CodPostalTextBox.Text = proveedor.CodPostal;
                PaisesComboBox.SelectedValue = proveedor.PaisId;
                HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox, proveedor.Pais);
                CiudadesComboBox.SelectedValue = proveedor.CiudadId;

            }
        }

        private Pais pais;
        private void PaisesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisesComboBox.SelectedIndex > 0)
            {
                pais = (Pais)PaisesComboBox.SelectedItem;
                HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox, pais);
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
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }

                proveedor.Nombre = ProveedorTextBox.Text;
                proveedor.Direccion = DireccionTextBox.Text;
                proveedor.CodPostal = CodPostalTextBox.Text;
                proveedor.PaisId = (int)PaisesComboBox.SelectedValue;
                proveedor.Pais = (Pais)PaisesComboBox.SelectedItem;
                proveedor.CiudadId = (int)CiudadesComboBox.SelectedValue;
                proveedor.Ciudad = (Ciudad)CiudadesComboBox.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ProveedorTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ProveedorTextBox, "El nombre del proveedor es requerido");
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La dirección es obligatoria");
            }

            if (string.IsNullOrEmpty(CodPostalTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(CodPostalTextBox, "El CP es requerido");
            }

            if (PaisesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(PaisesComboBox, "Debe seleccionar un país");
            }

            if (CiudadesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(CiudadesComboBox, "Debe seleccionar una ciudad");
            }

            return valido;
        }

        private void AgregarPaisIconPictureBox_Click(object sender, EventArgs e)
        {
            frmPaisesAE frm = new frmPaisesAE() { Text = "Agregar un país" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
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
            if (dr == DialogResult.Cancel)
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
    }
}
