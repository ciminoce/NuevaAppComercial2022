using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCategoriasAE : Form
    {
        public frmCategoriasAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria!=null)
            {
                CategoriaTextBox.Text = categoria.NombreCategoria;
                DescripcionTextBox.Text = categoria.Descripcion;
            }
        }

        private Categoria categoria;
        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }

        public Categoria GetCategoria()
        {
            return categoria;
        }
        private void CancelarIconButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, System.EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.NombreCategoria = CategoriaTextBox.Text;
                categoria.Descripcion = DescripcionTextBox.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(CategoriaTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(CategoriaTextBox, "El nombre del paìs es requerido");
            }

            return valido;
        }

    }
}
