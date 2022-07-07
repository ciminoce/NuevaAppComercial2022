using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            servicios = new UsuariosServicios();
        }

        private Usuario usuario;
        private UsuariosServicios servicios;

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea salir de la aplicación?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void AceptarIconButton_Click(object sender, EventArgs e)
        {
            //usuario = servicios.GetUsuario(UsuarioTextBox.Text, ClaveTextBox.Text);
            usuario = servicios.GetUsuario("admin", "123");
            if ( usuario!= null)
            {
                this.Hide();
                var frm = new frmInicio();
                frm.FormClosing += Frm_FormClosing;
                frm.SetUsuario(usuario);
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado" + Environment.NewLine + "o clave errónea",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                LimpiarTextos();
            }

        }

        private void LimpiarTextos()
        {
            UsuarioTextBox.Clear();
            ClaveTextBox.Clear();
            UsuarioTextBox.Focus();
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            LimpiarTextos();
        }
    }
}
