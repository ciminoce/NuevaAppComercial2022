
namespace NuevaAppComercial2022.Windows
{
    partial class frmCtasCtes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.EditarIconButton = new FontAwesome.Sharp.IconButton();
            this.BorrarIconButton = new FontAwesome.Sharp.IconButton();
            this.NuevoIconButton = new FontAwesome.Sharp.IconButton();
            this.DetalleIconButton = new FontAwesome.Sharp.IconButton();
            this.PagarIconButton = new FontAwesome.Sharp.IconButton();
            this.ImprimirIonButton = new FontAwesome.Sharp.IconButton();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.dgvDatos);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(800, 350);
            this.GrillaPanel.TabIndex = 5;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnCliente,
            this.cmnSaldo});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 350);
            this.dgvDatos.TabIndex = 2;
            // 
            // cmnCliente
            // 
            this.cmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCliente.HeaderText = "Cliente";
            this.cmnCliente.Name = "cmnCliente";
            this.cmnCliente.ReadOnly = true;
            // 
            // cmnSaldo
            // 
            this.cmnSaldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cmnSaldo.DefaultCellStyle = dataGridViewCellStyle8;
            this.cmnSaldo.HeaderText = "Saldo";
            this.cmnSaldo.Name = "cmnSaldo";
            this.cmnSaldo.ReadOnly = true;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToolBarPanel.Controls.Add(this.ImprimirIonButton);
            this.ToolBarPanel.Controls.Add(this.PagarIconButton);
            this.ToolBarPanel.Controls.Add(this.DetalleIconButton);
            this.ToolBarPanel.Controls.Add(this.EditarIconButton);
            this.ToolBarPanel.Controls.Add(this.BorrarIconButton);
            this.ToolBarPanel.Controls.Add(this.NuevoIconButton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(800, 100);
            this.ToolBarPanel.TabIndex = 4;
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
            // 
            // DetalleIconButton
            // 
            this.DetalleIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetalleIconButton.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.DetalleIconButton.IconColor = System.Drawing.Color.Green;
            this.DetalleIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetalleIconButton.Location = new System.Drawing.Point(245, 19);
            this.DetalleIconButton.Name = "DetalleIconButton";
            this.DetalleIconButton.Size = new System.Drawing.Size(62, 63);
            this.DetalleIconButton.TabIndex = 6;
            this.DetalleIconButton.Text = "Detalle";
            this.DetalleIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.DetalleIconButton.UseVisualStyleBackColor = true;
            this.DetalleIconButton.Click += new System.EventHandler(this.DetalleIconButton_Click);
            // 
            // PagarIconButton
            // 
            this.PagarIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagarIconButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.PagarIconButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PagarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PagarIconButton.Location = new System.Drawing.Point(357, 19);
            this.PagarIconButton.Name = "PagarIconButton";
            this.PagarIconButton.Size = new System.Drawing.Size(87, 63);
            this.PagarIconButton.TabIndex = 7;
            this.PagarIconButton.Text = "Pagar";
            this.PagarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PagarIconButton.UseVisualStyleBackColor = true;
            // 
            // ImprimirIonButton
            // 
            this.ImprimirIonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImprimirIonButton.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ImprimirIonButton.IconColor = System.Drawing.Color.White;
            this.ImprimirIonButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ImprimirIonButton.Location = new System.Drawing.Point(503, 19);
            this.ImprimirIonButton.Name = "ImprimirIonButton";
            this.ImprimirIonButton.Size = new System.Drawing.Size(87, 63);
            this.ImprimirIonButton.TabIndex = 8;
            this.ImprimirIonButton.Text = "Imprimir";
            this.ImprimirIonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ImprimirIonButton.UseVisualStyleBackColor = true;
            // 
            // frmCtasCtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "frmCtasCtes";
            this.Text = "frmCtasCtes";
            this.Load += new System.EventHandler(this.frmCtasCtes_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.Panel ToolBarPanel;
        private FontAwesome.Sharp.IconButton EditarIconButton;
        private FontAwesome.Sharp.IconButton BorrarIconButton;
        private FontAwesome.Sharp.IconButton NuevoIconButton;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSaldo;
        private FontAwesome.Sharp.IconButton DetalleIconButton;
        private FontAwesome.Sharp.IconButton PagarIconButton;
        private FontAwesome.Sharp.IconButton ImprimirIonButton;
    }
}