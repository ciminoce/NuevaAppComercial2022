using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmBuscarPaisCiudad : Form
    {
        public frmBuscarPaisCiudad()
        {
            InitializeComponent();
        }
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboPaises(ref PaisesComboBox);
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
            if (PaisesComboBox.SelectedIndex == 0 )
            {
                valido = false;
                errorProvider1.SetError(PaisesComboBox, "Debe seleccionar al menos un país");
            }

            return valido;
        }

        private Pais pais=null;
        private Ciudad ciudad = null;
        private void PaisesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisesComboBox.SelectedIndex > 0)
            {
                pais = (Pais)PaisesComboBox.SelectedItem;
                HelperCombos.CargarDatosComboCiudades(ref CiudadesComboBox, pais);

            }
            else
            {
                CiudadesComboBox.DataSource = null;
                pais = null;
            }
        }
        public Pais GetPais()
        {
            return pais;
        }

        private void CiudadesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CiudadesComboBox.SelectedIndex>0)
            {
                ciudad = (Ciudad)CiudadesComboBox.SelectedItem;
            }
            else
            {
                ciudad = null;
            }
        }

        public Ciudad GetCiudad()
        {
            return ciudad;
        }

    }
}
