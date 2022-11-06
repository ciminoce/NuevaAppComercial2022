using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmBuscarPais : Form
    {
        public frmBuscarPais()
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
            if (PaisesComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(PaisesComboBox,"Debe seleccionar un país");
            }

            return valido;
        }

        private Pais pais;
        private void PaisesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PaisesComboBox.SelectedIndex>0)
            {
                pais = (Pais)PaisesComboBox.SelectedItem;
            }
            else
            {
                pais = null;
            }
        }

        public Pais GetPais()
        {
            return pais;
        }
    }
}
