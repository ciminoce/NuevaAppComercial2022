
namespace NuevaAppComercial2022.Windows
{
    partial class frmProductosAE
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
            this.StockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoriasComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioVtaTextBox = new System.Windows.Forms.TextBox();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.BuscarIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.ProveedoresComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MinimoNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendidoCheckBox = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNmericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StockNumericUpDown
            // 
            this.StockNumericUpDown.Location = new System.Drawing.Point(155, 182);
            this.StockNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StockNumericUpDown.Name = "StockNumericUpDown";
            this.StockNumericUpDown.ReadOnly = true;
            this.StockNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.StockNumericUpDown.TabIndex = 25;
            this.StockNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Precio Vta:";
            // 
            // CategoriasComboBox
            // 
            this.CategoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriasComboBox.FormattingEnabled = true;
            this.CategoriasComboBox.Location = new System.Drawing.Point(155, 81);
            this.CategoriasComboBox.Name = "CategoriasComboBox";
            this.CategoriasComboBox.Size = new System.Drawing.Size(263, 21);
            this.CategoriasComboBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Producto:";
            // 
            // PrecioVtaTextBox
            // 
            this.PrecioVtaTextBox.Location = new System.Drawing.Point(155, 149);
            this.PrecioVtaTextBox.MaxLength = 200;
            this.PrecioVtaTextBox.Name = "PrecioVtaTextBox";
            this.PrecioVtaTextBox.Size = new System.Drawing.Size(263, 20);
            this.PrecioVtaTextBox.TabIndex = 18;
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(155, 48);
            this.ProductoTextBox.MaxLength = 200;
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(360, 20);
            this.ProductoTextBox.TabIndex = 19;
            // 
            // BuscarIconButton
            // 
            this.BuscarIconButton.BackColor = System.Drawing.Color.ForestGreen;
            this.BuscarIconButton.ForeColor = System.Drawing.Color.White;
            this.BuscarIconButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BuscarIconButton.IconColor = System.Drawing.Color.White;
            this.BuscarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarIconButton.IconSize = 32;
            this.BuscarIconButton.Location = new System.Drawing.Point(606, 182);
            this.BuscarIconButton.Name = "BuscarIconButton";
            this.BuscarIconButton.Size = new System.Drawing.Size(134, 36);
            this.BuscarIconButton.TabIndex = 15;
            this.BuscarIconButton.Text = "Buscar";
            this.BuscarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarIconButton.UseVisualStyleBackColor = false;
            this.BuscarIconButton.Click += new System.EventHandler(this.BuscarIconButton_Click);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(369, 282);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 59);
            this.CancelarIconButton.TabIndex = 16;
            this.CancelarIconButton.Text = "Cancelar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(121, 282);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 59);
            this.OKIconButton.TabIndex = 17;
            this.OKIconButton.Text = "Guardar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Proveedor:";
            // 
            // ProveedoresComboBox
            // 
            this.ProveedoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedoresComboBox.FormattingEnabled = true;
            this.ProveedoresComboBox.Location = new System.Drawing.Point(155, 115);
            this.ProveedoresComboBox.Name = "ProveedoresComboBox";
            this.ProveedoresComboBox.Size = new System.Drawing.Size(263, 21);
            this.ProveedoresComboBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Stock Mínimo:";
            // 
            // MinimoNmericUpDown
            // 
            this.MinimoNmericUpDown.Location = new System.Drawing.Point(155, 216);
            this.MinimoNmericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinimoNmericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimoNmericUpDown.Name = "MinimoNmericUpDown";
            this.MinimoNmericUpDown.ReadOnly = true;
            this.MinimoNmericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinimoNmericUpDown.TabIndex = 25;
            this.MinimoNmericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Suspendido:";
            // 
            // SuspendidoCheckBox
            // 
            this.SuspendidoCheckBox.AutoSize = true;
            this.SuspendidoCheckBox.Location = new System.Drawing.Point(155, 251);
            this.SuspendidoCheckBox.Name = "SuspendidoCheckBox";
            this.SuspendidoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SuspendidoCheckBox.TabIndex = 28;
            this.SuspendidoCheckBox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenPictureBox.Location = new System.Drawing.Point(592, 33);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(159, 143);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 29;
            this.ImagenPictureBox.TabStop = false;
            // 
            // frmProductosAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.SuspendidoCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinimoNmericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StockNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProveedoresComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoriasComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioVtaTextBox);
            this.Controls.Add(this.ProductoTextBox);
            this.Controls.Add(this.BuscarIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Name = "frmProductosAE";
            this.Text = "frmProductosAE";
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNmericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown StockNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoriasComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioVtaTextBox;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private FontAwesome.Sharp.IconButton BuscarIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ProveedoresComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MinimoNmericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox SuspendidoCheckBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
    }
}