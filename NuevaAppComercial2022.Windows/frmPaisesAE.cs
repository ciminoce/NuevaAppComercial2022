using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmPaisesAE : Form
    {
        public frmPaisesAE()
        {
            InitializeComponent();
        }

        private Pais pais;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (pais!=null)
            {
                PaisTextBox.Text = pais.NombrePais;
            }
        }

        public Pais GetPais()
        {
            return pais;
        }

        private void CancelarIconButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (pais==null)
                {
                    pais=new Pais();
                }

                pais.NombrePais = PaisTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(PaisTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(PaisTextBox,"El nombre del paìs es requerido");
            }

            return valido;
        }

        public void SetPais(Pais pais)
        {
            this.pais = pais;
        }
    }
}
