
namespace NuevaAppComercial2022.Windows
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraMenuStrip = new System.Windows.Forms.MenuStrip();
            this.UsuariosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.PaisesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.CiudadesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ClientesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ProveedoresMenu = new FontAwesome.Sharp.IconMenuItem();
            this.CategoriasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ProductosMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ComprasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.VentasMenu = new FontAwesome.Sharp.IconMenuItem();
            this.ReportesMenu = new FontAwesome.Sharp.IconMenuItem();
            this.CtaCteMenu = new FontAwesome.Sharp.IconMenuItem();
            this.TituloMenuStrip = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RolLabel = new System.Windows.Forms.Label();
            this.BarraMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenuStrip
            // 
            this.BarraMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosMenu,
            this.PaisesMenu,
            this.CiudadesMenu,
            this.ClientesMenu,
            this.ProveedoresMenu,
            this.CategoriasMenu,
            this.ProductosMenu,
            this.ComprasMenu,
            this.VentasMenu,
            this.ReportesMenu,
            this.CtaCteMenu});
            this.BarraMenuStrip.Location = new System.Drawing.Point(0, 64);
            this.BarraMenuStrip.Name = "BarraMenuStrip";
            this.BarraMenuStrip.Size = new System.Drawing.Size(1084, 73);
            this.BarraMenuStrip.TabIndex = 0;
            this.BarraMenuStrip.Text = "menuStrip1";
            // 
            // UsuariosMenu
            // 
            this.UsuariosMenu.AutoSize = false;
            this.UsuariosMenu.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.UsuariosMenu.IconColor = System.Drawing.Color.Black;
            this.UsuariosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UsuariosMenu.IconSize = 50;
            this.UsuariosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.UsuariosMenu.Name = "UsuariosMenu";
            this.UsuariosMenu.Size = new System.Drawing.Size(80, 69);
            this.UsuariosMenu.Text = "Usuarios";
            this.UsuariosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // PaisesMenu
            // 
            this.PaisesMenu.AutoSize = false;
            this.PaisesMenu.IconChar = FontAwesome.Sharp.IconChar.MapLocation;
            this.PaisesMenu.IconColor = System.Drawing.Color.Black;
            this.PaisesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PaisesMenu.IconSize = 50;
            this.PaisesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.PaisesMenu.Name = "PaisesMenu";
            this.PaisesMenu.Size = new System.Drawing.Size(80, 69);
            this.PaisesMenu.Text = "Países";
            this.PaisesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PaisesMenu.Click += new System.EventHandler(this.PaisesMenu_Click);
            // 
            // CiudadesMenu
            // 
            this.CiudadesMenu.AutoSize = false;
            this.CiudadesMenu.IconChar = FontAwesome.Sharp.IconChar.City;
            this.CiudadesMenu.IconColor = System.Drawing.Color.Black;
            this.CiudadesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CiudadesMenu.IconSize = 50;
            this.CiudadesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CiudadesMenu.Name = "CiudadesMenu";
            this.CiudadesMenu.Size = new System.Drawing.Size(80, 69);
            this.CiudadesMenu.Text = "Ciudades";
            this.CiudadesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CiudadesMenu.Click += new System.EventHandler(this.CiudadesMenu_Click);
            // 
            // ClientesMenu
            // 
            this.ClientesMenu.AutoSize = false;
            this.ClientesMenu.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.ClientesMenu.IconColor = System.Drawing.Color.Black;
            this.ClientesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientesMenu.IconSize = 50;
            this.ClientesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ClientesMenu.Name = "ClientesMenu";
            this.ClientesMenu.Size = new System.Drawing.Size(80, 69);
            this.ClientesMenu.Text = "Clientes";
            this.ClientesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClientesMenu.Click += new System.EventHandler(this.ClientesMenu_Click);
            // 
            // ProveedoresMenu
            // 
            this.ProveedoresMenu.AutoSize = false;
            this.ProveedoresMenu.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.ProveedoresMenu.IconColor = System.Drawing.Color.Black;
            this.ProveedoresMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProveedoresMenu.IconSize = 50;
            this.ProveedoresMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProveedoresMenu.Name = "ProveedoresMenu";
            this.ProveedoresMenu.Size = new System.Drawing.Size(80, 69);
            this.ProveedoresMenu.Text = "Proveedores";
            this.ProveedoresMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProveedoresMenu.Click += new System.EventHandler(this.ProveedoresMenu_Click);
            // 
            // CategoriasMenu
            // 
            this.CategoriasMenu.AutoSize = false;
            this.CategoriasMenu.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.CategoriasMenu.IconColor = System.Drawing.Color.Black;
            this.CategoriasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CategoriasMenu.IconSize = 50;
            this.CategoriasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CategoriasMenu.Name = "CategoriasMenu";
            this.CategoriasMenu.Size = new System.Drawing.Size(80, 69);
            this.CategoriasMenu.Text = "Categorias";
            this.CategoriasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CategoriasMenu.Click += new System.EventHandler(this.CategoriasMenu_Click);
            // 
            // ProductosMenu
            // 
            this.ProductosMenu.AutoSize = false;
            this.ProductosMenu.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.ProductosMenu.IconColor = System.Drawing.Color.Black;
            this.ProductosMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ProductosMenu.IconSize = 50;
            this.ProductosMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ProductosMenu.Name = "ProductosMenu";
            this.ProductosMenu.Size = new System.Drawing.Size(80, 69);
            this.ProductosMenu.Text = "Productos";
            this.ProductosMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ProductosMenu.Click += new System.EventHandler(this.ProductosMenu_Click);
            // 
            // ComprasMenu
            // 
            this.ComprasMenu.AutoSize = false;
            this.ComprasMenu.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            this.ComprasMenu.IconColor = System.Drawing.Color.Black;
            this.ComprasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ComprasMenu.IconSize = 50;
            this.ComprasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ComprasMenu.Name = "ComprasMenu";
            this.ComprasMenu.Size = new System.Drawing.Size(80, 69);
            this.ComprasMenu.Text = "Compras";
            this.ComprasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // VentasMenu
            // 
            this.VentasMenu.AutoSize = false;
            this.VentasMenu.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.VentasMenu.IconColor = System.Drawing.Color.Black;
            this.VentasMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VentasMenu.IconSize = 50;
            this.VentasMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VentasMenu.Name = "VentasMenu";
            this.VentasMenu.Size = new System.Drawing.Size(122, 69);
            this.VentasMenu.Text = "Ventas";
            this.VentasMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VentasMenu.Click += new System.EventHandler(this.VentasMenu_Click);
            // 
            // ReportesMenu
            // 
            this.ReportesMenu.AutoSize = false;
            this.ReportesMenu.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ReportesMenu.IconColor = System.Drawing.Color.Black;
            this.ReportesMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReportesMenu.IconSize = 50;
            this.ReportesMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReportesMenu.Name = "ReportesMenu";
            this.ReportesMenu.Size = new System.Drawing.Size(80, 69);
            this.ReportesMenu.Text = "Reportes";
            this.ReportesMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // CtaCteMenu
            // 
            this.CtaCteMenu.AutoSize = false;
            this.CtaCteMenu.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.CtaCteMenu.IconColor = System.Drawing.Color.Black;
            this.CtaCteMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CtaCteMenu.IconSize = 50;
            this.CtaCteMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CtaCteMenu.Name = "CtaCteMenu";
            this.CtaCteMenu.Size = new System.Drawing.Size(122, 69);
            this.CtaCteMenu.Text = "CtaCte";
            this.CtaCteMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CtaCteMenu.Click += new System.EventHandler(this.CtaCteMenu_Click);
            // 
            // TituloMenuStrip
            // 
            this.TituloMenuStrip.AutoSize = false;
            this.TituloMenuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.TituloMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TituloMenuStrip.Name = "TituloMenuStrip";
            this.TituloMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TituloMenuStrip.Size = new System.Drawing.Size(1084, 64);
            this.TituloMenuStrip.TabIndex = 1;
            this.TituloMenuStrip.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Ventas";
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorPanel.Location = new System.Drawing.Point(0, 137);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(1084, 612);
            this.contenedorPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(882, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.UsuarioLabel.Location = new System.Drawing.Point(966, 11);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(64, 17);
            this.UsuarioLabel.TabIndex = 4;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(882, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // RolLabel
            // 
            this.RolLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RolLabel.AutoSize = true;
            this.RolLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.RolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolLabel.ForeColor = System.Drawing.Color.White;
            this.RolLabel.Location = new System.Drawing.Point(966, 37);
            this.RolLabel.Name = "RolLabel";
            this.RolLabel.Size = new System.Drawing.Size(29, 17);
            this.RolLabel.TabIndex = 4;
            this.RolLabel.Text = "Rol";
            this.RolLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.RolLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraMenuStrip);
            this.Controls.Add(this.TituloMenuStrip);
            this.MainMenuStrip = this.BarraMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1100, 726);
            this.Name = "frmInicio";
            this.Text = "Sistema de Ventas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.BarraMenuStrip.ResumeLayout(false);
            this.BarraMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenuStrip;
        private System.Windows.Forms.MenuStrip TituloMenuStrip;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem UsuariosMenu;
        private FontAwesome.Sharp.IconMenuItem PaisesMenu;
        private FontAwesome.Sharp.IconMenuItem CiudadesMenu;
        private FontAwesome.Sharp.IconMenuItem ClientesMenu;
        private FontAwesome.Sharp.IconMenuItem ProveedoresMenu;
        private FontAwesome.Sharp.IconMenuItem CategoriasMenu;
        private FontAwesome.Sharp.IconMenuItem ProductosMenu;
        private FontAwesome.Sharp.IconMenuItem ComprasMenu;
        private FontAwesome.Sharp.IconMenuItem VentasMenu;
        private FontAwesome.Sharp.IconMenuItem ReportesMenu;
        private System.Windows.Forms.Panel contenedorPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RolLabel;
        private FontAwesome.Sharp.IconMenuItem CtaCteMenu;
    }
}

