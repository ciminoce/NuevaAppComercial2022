
namespace NuevaAppComercial2022.Windows.UserControls
{
    partial class ucProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.Location = new System.Drawing.Point(4, 4);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(100, 93);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 0;
            this.ImagenPictureBox.TabStop = false;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionLabel.ForeColor = System.Drawing.Color.Sienna;
            this.DescripcionLabel.Location = new System.Drawing.Point(4, 115);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(83, 15);
            this.DescripcionLabel.TabIndex = 1;
            this.DescripcionLabel.Text = "Descripción";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.ForeColor = System.Drawing.Color.Sienna;
            this.StockLabel.Location = new System.Drawing.Point(107, 28);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(42, 15);
            this.StockLabel.TabIndex = 1;
            this.StockLabel.Text = "Stock";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioLabel.ForeColor = System.Drawing.Color.Sienna;
            this.PrecioLabel.Location = new System.Drawing.Point(106, 63);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(48, 15);
            this.PrecioLabel.TabIndex = 1;
            this.PrecioLabel.Text = "Precio";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(39, 141);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(125, 31);
            this.AgregarButton.TabIndex = 2;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // ucProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.ImagenPictureBox);
            this.Name = "ucProducto";
            this.Size = new System.Drawing.Size(196, 181);
            this.MouseEnter += new System.EventHandler(this.ucProducto_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucProducto_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Label PrecioLabel;
        public System.Windows.Forms.Button AgregarButton;
        public System.Windows.Forms.Label StockLabel;
    }
}
