
namespace NuevaAppComercial2022.Windows
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.UltimoIconButton = new FontAwesome.Sharp.IconButton();
            this.SiguienteIconButton = new FontAwesome.Sharp.IconButton();
            this.AnteriorIconButton = new FontAwesome.Sharp.IconButton();
            this.PrimeroIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltroIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ClienteBuscarTextBox = new System.Windows.Forms.TextBox();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.DatosDataGridView);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(1083, 350);
            this.GrillaPanel.TabIndex = 3;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCliente,
            this.colDireccion,
            this.colPais,
            this.colCiudad,
            this.colCodPostal});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(1083, 350);
            this.DatosDataGridView.TabIndex = 1;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            // 
            // colPais
            // 
            this.colPais.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPais.HeaderText = "País";
            this.colPais.Name = "colPais";
            this.colPais.ReadOnly = true;
            this.colPais.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCiudad
            // 
            this.colCiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCiudad.HeaderText = "Ciudad";
            this.colCiudad.Name = "colCiudad";
            this.colCiudad.ReadOnly = true;
            // 
            // colCodPostal
            // 
            this.colCodPostal.FillWeight = 20F;
            this.colCodPostal.HeaderText = "Cod.Postal";
            this.colCodPostal.Name = "colCodPostal";
            this.colCodPostal.ReadOnly = true;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToolBarPanel.Controls.Add(this.ClienteBuscarTextBox);
            this.ToolBarPanel.Controls.Add(this.label1);
            this.ToolBarPanel.Controls.Add(this.UltimoIconButton);
            this.ToolBarPanel.Controls.Add(this.SiguienteIconButton);
            this.ToolBarPanel.Controls.Add(this.AnteriorIconButton);
            this.ToolBarPanel.Controls.Add(this.PrimeroIconButton);
            this.ToolBarPanel.Controls.Add(this.iconButton1);
            this.ToolBarPanel.Controls.Add(this.FiltroIconButton);
            this.ToolBarPanel.Controls.Add(this.EditarIconButton);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.NuevoIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(1083, 100);
            this.ToolBarPanel.TabIndex = 2;
            // 
            // UltimoIconButton
            // 
            this.UltimoIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UltimoIconButton.IconChar = FontAwesome.Sharp.IconChar.ForwardFast;
            this.UltimoIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.UltimoIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UltimoIconButton.Location = new System.Drawing.Point(966, 19);
            this.UltimoIconButton.Name = "UltimoIconButton";
            this.UltimoIconButton.Size = new System.Drawing.Size(62, 63);
            this.UltimoIconButton.TabIndex = 2;
            this.UltimoIconButton.Text = "Último";
            this.UltimoIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.UltimoIconButton.UseVisualStyleBackColor = true;
            this.UltimoIconButton.Click += new System.EventHandler(this.UltimoIconButton_Click);
            // 
            // SiguienteIconButton
            // 
            this.SiguienteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SiguienteIconButton.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.SiguienteIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.SiguienteIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SiguienteIconButton.Location = new System.Drawing.Point(898, 19);
            this.SiguienteIconButton.Name = "SiguienteIconButton";
            this.SiguienteIconButton.Size = new System.Drawing.Size(62, 63);
            this.SiguienteIconButton.TabIndex = 2;
            this.SiguienteIconButton.Text = "Siguiente";
            this.SiguienteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SiguienteIconButton.UseVisualStyleBackColor = true;
            this.SiguienteIconButton.Click += new System.EventHandler(this.SiguienteIconButton_Click);
            // 
            // AnteriorIconButton
            // 
            this.AnteriorIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnteriorIconButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.AnteriorIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.AnteriorIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AnteriorIconButton.Location = new System.Drawing.Point(830, 19);
            this.AnteriorIconButton.Name = "AnteriorIconButton";
            this.AnteriorIconButton.Size = new System.Drawing.Size(62, 63);
            this.AnteriorIconButton.TabIndex = 2;
            this.AnteriorIconButton.Text = "Anterior";
            this.AnteriorIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AnteriorIconButton.UseVisualStyleBackColor = true;
            this.AnteriorIconButton.Click += new System.EventHandler(this.AnteriorIconButton_Click);
            // 
            // PrimeroIconButton
            // 
            this.PrimeroIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrimeroIconButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.PrimeroIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.PrimeroIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PrimeroIconButton.Location = new System.Drawing.Point(762, 19);
            this.PrimeroIconButton.Name = "PrimeroIconButton";
            this.PrimeroIconButton.Size = new System.Drawing.Size(62, 63);
            this.PrimeroIconButton.TabIndex = 2;
            this.PrimeroIconButton.Text = "Primero";
            this.PrimeroIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrimeroIconButton.UseVisualStyleBackColor = true;
            this.PrimeroIconButton.Click += new System.EventHandler(this.PrimeroIconButton_Click);
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
            this.FiltroIconButton.Click += new System.EventHandler(this.FiltrarIconButton_Click);
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
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(320, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(62, 63);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // ClienteBuscarTextBox
            // 
            this.ClienteBuscarTextBox.Enabled = false;
            this.ClienteBuscarTextBox.Location = new System.Drawing.Point(451, 40);
            this.ClienteBuscarTextBox.Name = "ClienteBuscarTextBox";
            this.ClienteBuscarTextBox.Size = new System.Drawing.Size(245, 20);
            this.ClienteBuscarTextBox.TabIndex = 7;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton FiltroIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodPostal;
        private FontAwesome.Sharp.IconButton UltimoIconButton;
        private FontAwesome.Sharp.IconButton SiguienteIconButton;
        private FontAwesome.Sharp.IconButton AnteriorIconButton;
        private FontAwesome.Sharp.IconButton PrimeroIconButton;
        private System.Windows.Forms.TextBox ClienteBuscarTextBox;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}