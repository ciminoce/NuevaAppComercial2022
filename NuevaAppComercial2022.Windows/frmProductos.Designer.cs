
namespace NuevaAppComercial2022.Windows
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.cmnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSuspendido = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PaginacionPanel = new System.Windows.Forms.Panel();
            this.TotalPaginasTextBox = new System.Windows.Forms.TextBox();
            this.PaginasComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.FiltroIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.PaginacionPanel.SuspendLayout();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.DatosDataGridView);
            this.GrillaPanel.Controls.Add(this.PaginacionPanel);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(958, 462);
            this.GrillaPanel.TabIndex = 3;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnProducto,
            this.cmnCategoria,
            this.cmnPrecio,
            this.cmnStock,
            this.cmnSuspendido});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(958, 398);
            this.DatosDataGridView.TabIndex = 4;
            // 
            // cmnProducto
            // 
            this.cmnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProducto.HeaderText = "Producto";
            this.cmnProducto.Name = "cmnProducto";
            this.cmnProducto.ReadOnly = true;
            this.cmnProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnCategoria
            // 
            this.cmnCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCategoria.HeaderText = "Categoría";
            this.cmnCategoria.Name = "cmnCategoria";
            this.cmnCategoria.ReadOnly = true;
            this.cmnCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cmnPrecio
            // 
            this.cmnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnPrecio.HeaderText = "Precio";
            this.cmnPrecio.Name = "cmnPrecio";
            this.cmnPrecio.ReadOnly = true;
            this.cmnPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cmnPrecio.Width = 43;
            // 
            // cmnStock
            // 
            this.cmnStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnStock.HeaderText = "Stock";
            this.cmnStock.Name = "cmnStock";
            this.cmnStock.ReadOnly = true;
            this.cmnStock.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cmnStock.Width = 41;
            // 
            // cmnSuspendido
            // 
            this.cmnSuspendido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnSuspendido.HeaderText = "Suspendido";
            this.cmnSuspendido.Name = "cmnSuspendido";
            this.cmnSuspendido.ReadOnly = true;
            this.cmnSuspendido.Width = 69;
            // 
            // PaginacionPanel
            // 
            this.PaginacionPanel.Controls.Add(this.TotalPaginasTextBox);
            this.PaginacionPanel.Controls.Add(this.PaginasComboBox);
            this.PaginacionPanel.Controls.Add(this.label2);
            this.PaginacionPanel.Controls.Add(this.label1);
            this.PaginacionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginacionPanel.Location = new System.Drawing.Point(0, 398);
            this.PaginacionPanel.Name = "PaginacionPanel";
            this.PaginacionPanel.Size = new System.Drawing.Size(958, 64);
            this.PaginacionPanel.TabIndex = 3;
            // 
            // TotalPaginasTextBox
            // 
            this.TotalPaginasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPaginasTextBox.Enabled = false;
            this.TotalPaginasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaginasTextBox.Location = new System.Drawing.Point(778, 23);
            this.TotalPaginasTextBox.Name = "TotalPaginasTextBox";
            this.TotalPaginasTextBox.Size = new System.Drawing.Size(42, 20);
            this.TotalPaginasTextBox.TabIndex = 2;
            // 
            // PaginasComboBox
            // 
            this.PaginasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaginasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaginasComboBox.FormattingEnabled = true;
            this.PaginasComboBox.Location = new System.Drawing.Point(702, 23);
            this.PaginasComboBox.Name = "PaginasComboBox";
            this.PaginasComboBox.Size = new System.Drawing.Size(39, 21);
            this.PaginasComboBox.TabIndex = 1;
            this.PaginasComboBox.SelectionChangeCommitted += new System.EventHandler(this.PaginasComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = " de ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pág.:";
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToolBarPanel.Controls.Add(this.FiltroIconButton);
            this.ToolBarPanel.Controls.Add(this.EditarIconButton);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.NuevoIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(958, 100);
            this.ToolBarPanel.TabIndex = 2;
            // 
            // FiltroIconButton
            // 
            this.FiltroIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltroIconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltroIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.FiltroIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltroIconButton.Location = new System.Drawing.Point(231, 19);
            this.FiltroIconButton.Name = "FiltroIconButton";
            this.FiltroIconButton.Size = new System.Drawing.Size(62, 63);
            this.FiltroIconButton.TabIndex = 2;
            this.FiltroIconButton.Text = "Filtrar";
            this.FiltroIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltroIconButton.UseVisualStyleBackColor = true;
            this.FiltroIconButton.Click += new System.EventHandler(this.FiltroIconButton_Click);
            // 
            // EditarIconButton
            // 
            this.EditarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarIconButton.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.EditarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarIconButton.Location = new System.Drawing.Point(149, 19);
            this.EditarIconButton.Name = "EditarIconButton";
            this.EditarIconButton.Size = new System.Drawing.Size(62, 63);
            this.EditarIconButton.TabIndex = 3;
            this.EditarIconButton.Text = "Editar";
            this.EditarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarIconButton.UseVisualStyleBackColor = true;
            this.EditarIconButton.Click += new System.EventHandler(this.EditarIconButton_Click);
            // 
            // BorrarIconButton
            // 
            this.BorrarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrarIconButton.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BorrarIconButton.IconColor = System.Drawing.Color.Red;
            this.BorrarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BorrarIconButton.Location = new System.Drawing.Point(81, 19);
            this.BorrarIconButton.Name = "BorrarIconButton";
            this.BorrarIconButton.Size = new System.Drawing.Size(62, 63);
            this.BorrarIconButton.TabIndex = 4;
            this.BorrarIconButton.Text = "Borrar";
            this.BorrarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarIconButton.UseVisualStyleBackColor = true;
            this.BorrarIconButton.Click += new System.EventHandler(this.BorrarIconButton_Click);
            // 
            // NuevoIconButton
            // 
            this.NuevoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoIconButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.NuevoIconButton.IconColor = System.Drawing.Color.LimeGreen;
            this.NuevoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NuevoIconButton.Location = new System.Drawing.Point(13, 19);
            this.NuevoIconButton.Name = "NuevoIconButton";
            this.NuevoIconButton.Size = new System.Drawing.Size(62, 63);
            this.NuevoIconButton.TabIndex = 5;
            this.NuevoIconButton.Text = "Nuevo";
            this.NuevoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoIconButton.UseVisualStyleBackColor = true;
            this.NuevoIconButton.Click += new System.EventHandler(this.NuevoIconButton_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 562);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.PaginacionPanel.ResumeLayout(false);
            this.PaginacionPanel.PerformLayout();
            this.ToolBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cmnSuspendido;
        private System.Windows.Forms.Panel PaginacionPanel;
        private System.Windows.Forms.TextBox TotalPaginasTextBox;
        private System.Windows.Forms.ComboBox PaginasComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton FiltroIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
    }
}