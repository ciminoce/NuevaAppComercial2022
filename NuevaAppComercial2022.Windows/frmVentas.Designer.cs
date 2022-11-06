
namespace NuevaAppComercial2022.Windows
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.PaginacionPanel = new System.Windows.Forms.Panel();
            this.TotalPaginasTextBox = new System.Windows.Forms.TextBox();
            this.PaginasComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.PagarIconButton = new FontAwesome.Sharp.IconButton();
            this.ActualizarIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltroClienteIconButton = new FontAwesome.Sharp.IconButton();
            this.FiltroIconButton = new FontAwesome.Sharp.IconButton();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.GrillaPanel.SuspendLayout();
            this.PaginacionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.PaginacionPanel);
            this.GrillaPanel.Controls.Add(this.DatosDataGridView);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(800, 350);
            this.GrillaPanel.TabIndex = 3;
            // 
            // PaginacionPanel
            // 
            this.PaginacionPanel.Controls.Add(this.TotalPaginasTextBox);
            this.PaginacionPanel.Controls.Add(this.PaginasComboBox);
            this.PaginacionPanel.Controls.Add(this.label2);
            this.PaginacionPanel.Controls.Add(this.label1);
            this.PaginacionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaginacionPanel.Location = new System.Drawing.Point(0, 286);
            this.PaginacionPanel.Name = "PaginacionPanel";
            this.PaginacionPanel.Size = new System.Drawing.Size(800, 64);
            this.PaginacionPanel.TabIndex = 3;
            // 
            // TotalPaginasTextBox
            // 
            this.TotalPaginasTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalPaginasTextBox.Enabled = false;
            this.TotalPaginasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPaginasTextBox.Location = new System.Drawing.Point(620, 23);
            this.TotalPaginasTextBox.Name = "TotalPaginasTextBox";
            this.TotalPaginasTextBox.Size = new System.Drawing.Size(42, 20);
            this.TotalPaginasTextBox.TabIndex = 2;
            // 
            // PaginasComboBox
            // 
            this.PaginasComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PaginasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaginasComboBox.FormattingEnabled = true;
            this.PaginasComboBox.Location = new System.Drawing.Point(544, 23);
            this.PaginasComboBox.Name = "PaginasComboBox";
            this.PaginasComboBox.Size = new System.Drawing.Size(39, 21);
            this.PaginasComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = " de ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pág.:";
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DatosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVenta,
            this.colCliente,
            this.colFechaVenta,
            this.colTotal,
            this.colEstado});
            this.DatosDataGridView.Location = new System.Drawing.Point(3, 3);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(794, 280);
            this.DatosDataGridView.TabIndex = 1;
            this.DatosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosDataGridView_CellContentClick);
            this.DatosDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatosDataGridView_RowHeaderMouseClick);
            // 
            // colVenta
            // 
            this.colVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVenta.HeaderText = "Vta. Nro.";
            this.colVenta.Name = "colVenta";
            this.colVenta.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colFechaVenta
            // 
            this.colFechaVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFechaVenta.HeaderText = "Fecha Vta.";
            this.colFechaVenta.Name = "colFechaVenta";
            this.colFechaVenta.ReadOnly = true;
            // 
            // colTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToolBarPanel.Controls.Add(this.DetalleIconButton);
            this.ToolBarPanel.Controls.Add(this.PagarIconButton);
            this.ToolBarPanel.Controls.Add(this.ActualizarIconButton);
            this.ToolBarPanel.Controls.Add(this.FiltroClienteIconButton);
            this.ToolBarPanel.Controls.Add(this.FiltroIconButton);
            this.ToolBarPanel.Controls.Add(this.EditarIconButton);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.NuevoIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(800, 100);
            this.ToolBarPanel.TabIndex = 2;
            // 
            // DetalleIconButton
            // 
            this.DetalleIconButton.Enabled = false;
            this.DetalleIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleIconButton.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.DetalleIconButton.IconColor = System.Drawing.Color.Green;
            this.DetalleIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetalleIconButton.Location = new System.Drawing.Point(236, 19);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(62, 63);
            this.DetalleIconButton.TabIndex = 2;
            this.DetalleIconButton.Text = "Detalle";
            this.DetalleIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DetalleIconButton.UseVisualStyleBackColor = true;
            this.DetalleIconButton.Click += new System.EventHandler(this.DetalleIconButton_Click);
            // 
            // PagarIconButton
            // 
            this.PagarIconButton.Enabled = false;
            this.PagarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagarIconButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.PagarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PagarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PagarIconButton.Location = new System.Drawing.Point(685, 19);
            this.PagarIconButton.Name = "PagarIconButton";
            this.PagarIconButton.Size = new System.Drawing.Size(87, 63);
            this.PagarIconButton.TabIndex = 2;
            this.PagarIconButton.Text = "Pagar";
            this.PagarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PagarIconButton.UseVisualStyleBackColor = true;
            this.PagarIconButton.Click += new System.EventHandler(this.PagarIconButton_Click);
            // 
            // ActualizarIconButton
            // 
            this.ActualizarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActualizarIconButton.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.ActualizarIconButton.IconColor = System.Drawing.Color.Maroon;
            this.ActualizarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ActualizarIconButton.Location = new System.Drawing.Point(527, 19);
            this.ActualizarIconButton.Name = "ActualizarIconButton";
            this.ActualizarIconButton.Size = new System.Drawing.Size(87, 63);
            this.ActualizarIconButton.TabIndex = 2;
            this.ActualizarIconButton.Text = "Actualizar";
            this.ActualizarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarIconButton.UseVisualStyleBackColor = true;
            this.ActualizarIconButton.Click += new System.EventHandler(this.ActualizarIconButton_Click);
            // 
            // FiltroClienteIconButton
            // 
            this.FiltroClienteIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltroClienteIconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltroClienteIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FiltroClienteIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltroClienteIconButton.Location = new System.Drawing.Point(427, 19);
            this.FiltroClienteIconButton.Name = "FiltroClienteIconButton";
            this.FiltroClienteIconButton.Size = new System.Drawing.Size(87, 63);
            this.FiltroClienteIconButton.TabIndex = 2;
            this.FiltroClienteIconButton.Text = "Filtrar Cliente";
            this.FiltroClienteIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FiltroClienteIconButton.UseVisualStyleBackColor = true;
            this.FiltroClienteIconButton.Click += new System.EventHandler(this.FiltroClienteIconButton_Click);
            // 
            // FiltroIconButton
            // 
            this.FiltroIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltroIconButton.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.FiltroIconButton.IconColor = System.Drawing.Color.Goldenrod;
            this.FiltroIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FiltroIconButton.Location = new System.Drawing.Point(334, 19);
            this.FiltroIconButton.Name = "FiltroIconButton";
            this.FiltroIconButton.Size = new System.Drawing.Size(87, 63);
            this.FiltroIconButton.TabIndex = 2;
            this.FiltroIconButton.Text = "Filtrar Fecha";
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
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.GrillaPanel.ResumeLayout(false);
            this.PaginacionPanel.ResumeLayout(false);
            this.PaginacionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.Panel PaginacionPanel;
        private System.Windows.Forms.TextBox TotalPaginasTextBox;
        private System.Windows.Forms.ComboBox PaginasComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton FiltroIconButton;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
        private FontAwesome.Sharp.IconButton FiltroClienteIconButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private FontAwesome.Sharp.IconButton PagarIconButton;
        private FontAwesome.Sharp.IconButton ActualizarIconButton;
    }
}