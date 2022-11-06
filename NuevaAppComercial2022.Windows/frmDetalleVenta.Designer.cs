
namespace NuevaAppComercial2022.Windows
{
    partial class frmDetalleVenta
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
            this.EncabezadoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VentaNroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaVtaTextBox = new System.Windows.Forms.TextBox();
            this.TotalesPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalVtaTextBox = new System.Windows.Forms.TextBox();
            this.DetallePanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EncabezadoPanel.SuspendLayout();
            this.TotalesPanel.SuspendLayout();
            this.DetallePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EncabezadoPanel
            // 
            this.EncabezadoPanel.BackColor = System.Drawing.Color.LightGray;
            this.EncabezadoPanel.Controls.Add(this.FechaVtaTextBox);
            this.EncabezadoPanel.Controls.Add(this.label3);
            this.EncabezadoPanel.Controls.Add(this.ClienteTextBox);
            this.EncabezadoPanel.Controls.Add(this.label2);
            this.EncabezadoPanel.Controls.Add(this.VentaNroTextBox);
            this.EncabezadoPanel.Controls.Add(this.label1);
            this.EncabezadoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EncabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.EncabezadoPanel.Name = "EncabezadoPanel";
            this.EncabezadoPanel.Size = new System.Drawing.Size(800, 107);
            this.EncabezadoPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta Nro:";
            // 
            // VentaNroTextBox
            // 
            this.VentaNroTextBox.Enabled = false;
            this.VentaNroTextBox.Location = new System.Drawing.Point(90, 11);
            this.VentaNroTextBox.Name = "VentaNroTextBox";
            this.VentaNroTextBox.Size = new System.Drawing.Size(84, 20);
            this.VentaNroTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente:";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Enabled = false;
            this.ClienteTextBox.Location = new System.Drawing.Point(90, 37);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(435, 20);
            this.ClienteTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha Vta:";
            // 
            // FechaVtaTextBox
            // 
            this.FechaVtaTextBox.Enabled = false;
            this.FechaVtaTextBox.Location = new System.Drawing.Point(90, 63);
            this.FechaVtaTextBox.Name = "FechaVtaTextBox";
            this.FechaVtaTextBox.Size = new System.Drawing.Size(131, 20);
            this.FechaVtaTextBox.TabIndex = 1;
            // 
            // TotalesPanel
            // 
            this.TotalesPanel.Controls.Add(this.TotalVtaTextBox);
            this.TotalesPanel.Controls.Add(this.label4);
            this.TotalesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalesPanel.Location = new System.Drawing.Point(0, 375);
            this.TotalesPanel.Name = "TotalesPanel";
            this.TotalesPanel.Size = new System.Drawing.Size(800, 75);
            this.TotalesPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TotalVtaTextBox
            // 
            this.TotalVtaTextBox.Enabled = false;
            this.TotalVtaTextBox.Location = new System.Drawing.Point(728, 6);
            this.TotalVtaTextBox.Name = "TotalVtaTextBox";
            this.TotalVtaTextBox.Size = new System.Drawing.Size(60, 20);
            this.TotalVtaTextBox.TabIndex = 1;
            // 
            // DetallePanel
            // 
            this.DetallePanel.Controls.Add(this.DatosDataGridView);
            this.DetallePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallePanel.Location = new System.Drawing.Point(0, 107);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.Size = new System.Drawing.Size(800, 268);
            this.DetallePanel.TabIndex = 2;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubtotal});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.Size = new System.Drawing.Size(800, 268);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 74;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrecioUnitario.HeaderText = "P. Unit.";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.ReadOnly = true;
            this.colPrecioUnitario.Width = 67;
            // 
            // colSubtotal
            // 
            this.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 71;
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.TotalesPanel);
            this.Controls.Add(this.EncabezadoPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalleVenta";
            this.EncabezadoPanel.ResumeLayout(false);
            this.EncabezadoPanel.PerformLayout();
            this.TotalesPanel.ResumeLayout(false);
            this.TotalesPanel.PerformLayout();
            this.DetallePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EncabezadoPanel;
        private System.Windows.Forms.TextBox FechaVtaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VentaNroTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel TotalesPanel;
        private System.Windows.Forms.TextBox TotalVtaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel DetallePanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}