using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmInicio : Form
    {

        private IconMenuItem menuActivo = null;
        private Form formularioActivo = null;
        public frmInicio()
        {
            InitializeComponent();
        }

        private Usuario usuario;

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (usuario!=null)
            {
                UsuarioLabel.Text = usuario.NombreUsuario;
                RolLabel.Text = usuario.Rol.Descripcion;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            HabilitarMenu();
        }

        private void HabilitarMenu()
        {
            foreach (IconMenuItem item in BarraMenuStrip.Items)
            {
                //if (BuscarMenu(item))
                //{
                //    item.Visible = true;
                //}
                //else
                //{
                //    item.Visible = false;
                //}
                item.Visible = usuario.Rol.Permisos.Any(p => p.NombreMenu == item.Name);
            }
        }
        /// <summary>
        /// Funcion para buscar un item de menu dentro de los permisos
        /// </summary>
        /// <param name="item">El menú que se busca</param>
        /// <returns></returns>
        private bool BuscarMenu(IconMenuItem item)
        {
            var permiso = usuario.Rol
                .Permisos.SingleOrDefault(p => p.NombreMenu == item.Name);
            if (permiso!=null)
            {
                return true;
            }

            return false;
        }
        /// <summary>
        /// Metodo para abrir el formulario activo
        /// </summary>
        /// <param name="menu">Menu que se activa</param>
        /// <param name="formulario">Formulario que se abre</param>
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo!=null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo!=null)
            {
                formularioActivo.Close();
            }

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            formularioActivo = formulario;

            contenedorPanel.Controls.Add(formulario);

            formulario.Show();

        }
        private void PaisesMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmPaises());
        }

        private void CiudadesMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCiudades());
        }

        private void CategoriasMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCategorias());
        }

        private void ClientesMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void ProveedoresMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender,new frmProveedores());
        }

        private void ProductosMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProductos());

        }

        private void VentasMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVentas());
        }

        private void CtaCteMenu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCtasCtes());

        }
    }
}
