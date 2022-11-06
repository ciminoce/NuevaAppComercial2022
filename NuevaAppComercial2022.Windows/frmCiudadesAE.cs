using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCiudadesAE : Form
    {
        public frmCiudadesAE()
        {
            InitializeComponent();
        }

        private Ciudad ciudad;
        private PaisesServicios servicio;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio=new PaisesServicios();
            HelperCombos.CargarDatosComboPaises(ref PaisesComboBox);
            if (pais!=null)
            {
                PaisesComboBox.SelectedValue = pais.PaisId;
            }
            if (ciudad!=null)
            {
                CiudadTextBox.Text = ciudad.NombreCiudad;
                PaisesComboBox.SelectedValue = ciudad.PaisId;
            }
        }


        public Ciudad GetCiudad()
        {
            return ciudad;
        }

        private void CancelarIconButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (ciudad==null)
                {
                    ciudad=new Ciudad();
                }

                ciudad.NombreCiudad = CiudadTextBox.Text;
                ciudad.Pais =(Pais) PaisesComboBox.SelectedItem;
                ciudad.PaisId = ((Pais) PaisesComboBox.SelectedItem).PaisId;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (PaisesComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(PaisesComboBox,"Debe seleccionar un País");

            }

            if (string.IsNullOrEmpty(CiudadTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(CiudadTextBox,"El nombre de la ciudad es requerido");
            }

            return valido;
        }

        public void SetCiudad(Ciudad ciudad)
        {
            this.ciudad = ciudad;
        }

        private Pais pais;
        internal void SetPais(Pais pais)
        {
            this.pais = pais;
        }
    }
}
