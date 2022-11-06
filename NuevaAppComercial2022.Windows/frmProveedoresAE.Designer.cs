
namespace NuevaAppComercial2022.Windows
{
    partial class frmProveedoresAE
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
            this.components = new System.ComponentModel.Container();
            this.AgregarCiudadIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.AgregarPaisIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.CiudadesComboBox = new System.Windows.Forms.ComboBox();
            this.PaisesComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.CodPostalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCiudadIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarPaisIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarCiudadIconPictureBox
            // 
            this.AgregarCiudadIconPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.AgregarCiudadIconPictureBox.Enabled = false;
            this.AgregarCiudadIconPictureBox.ForeColor = System.Drawing.Color.Lime;
            this.AgregarCiudadIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarCiudadIconPictureBox.IconColor = System.Drawing.Color.Lime;
            this.AgregarCiudadIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarCiudadIconPictureBox.IconSize = 31;
            this.AgregarCiudadIconPictureBox.Location = new System.Drawing.Point(374, 138);
            this.AgregarCiudadIconPictureBox.Name = "AgregarCiudadIconPictureBox";
            this.AgregarCiudadIconPictureBox.Size = new System.Drawing.Size(31, 34);
            this.AgregarCiudadIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AgregarCiudadIconPictureBox.TabIndex = 29;
            this.AgregarCiudadIconPictureBox.TabStop = false;
            this.AgregarCiudadIconPictureBox.Click += new System.EventHandler(this.AgregarCiudadIconPictureBox_Click);
            // 
            // AgregarPaisIconPictureBox
            // 
            this.AgregarPaisIconPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.AgregarPaisIconPictureBox.ForeColor = System.Drawing.Color.Lime;
            this.AgregarPaisIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarPaisIconPictureBox.IconColor = System.Drawing.Color.Lime;
            this.AgregarPaisIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarPaisIconPictureBox.IconSize = 31;
            this.AgregarPaisIconPictureBox.Location = new System.Drawing.Point(374, 100);
            this.AgregarPaisIconPictureBox.Name = "AgregarPaisIconPictureBox";
            this.AgregarPaisIconPictureBox.Size = new System.Drawing.Size(31, 34);
            this.AgregarPaisIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AgregarPaisIconPictureBox.TabIndex = 30;
            this.AgregarPaisIconPictureBox.TabStop = false;
            this.AgregarPaisIconPictureBox.Click += new System.EventHandler(this.AgregarPaisIconPictureBox_Click);
            // 
            // CiudadesComboBox
            // 
            this.CiudadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadesComboBox.FormattingEnabled = true;
            this.CiudadesComboBox.Location = new System.Drawing.Point(87, 141);
            this.CiudadesComboBox.Name = "CiudadesComboBox";
            this.CiudadesComboBox.Size = new System.Drawing.Size(282, 21);
            this.CiudadesComboBox.TabIndex = 19;
            // 
            // PaisesComboBox
            // 
            this.PaisesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisesComboBox.FormattingEnabled = true;
            this.PaisesComboBox.Location = new System.Drawing.Point(87, 105);
            this.PaisesComboBox.Name = "PaisesComboBox";
            this.PaisesComboBox.Size = new System.Drawing.Size(282, 21);
            this.PaisesComboBox.TabIndex = 18;
            this.PaisesComboBox.SelectedIndexChanged += new System.EventHandler(this.PaisesComboBox_SelectedIndexChanged);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(449, 208);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 59);
            this.CancelarIconButton.TabIndex = 22;
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
            this.OKIconButton.Location = new System.Drawing.Point(87, 208);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 59);
            this.OKIconButton.TabIndex = 21;
            this.OKIconButton.Text = "Guardar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // ProveedorTextBox
            // 
            this.ProveedorTextBox.Location = new System.Drawing.Point(87, 31);
            this.ProveedorTextBox.MaxLength = 255;
            this.ProveedorTextBox.Name = "ProveedorTextBox";
            this.ProveedorTextBox.Size = new System.Drawing.Size(282, 20);
            this.ProveedorTextBox.TabIndex = 16;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(87, 67);
            this.DireccionTextBox.MaxLength = 255;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(352, 20);
            this.DireccionTextBox.TabIndex = 17;
            // 
            // CodPostalTextBox
            // 
            this.CodPostalTextBox.Location = new System.Drawing.Point(516, 67);
            this.CodPostalTextBox.MaxLength = 10;
            this.CodPostalTextBox.Name = "CodPostalTextBox";
            this.CodPostalTextBox.Size = new System.Drawing.Size(95, 20);
            this.CodPostalTextBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Razón Social:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ciudad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "País:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(446, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cod. Postal:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProveedoresAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 284);
            this.ControlBox = false;
            this.Controls.Add(this.AgregarCiudadIconPictureBox);
            this.Controls.Add(this.AgregarPaisIconPictureBox);
            this.Controls.Add(this.CiudadesComboBox);
            this.Controls.Add(this.PaisesComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.ProveedorTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.CodPostalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProveedoresAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCiudadIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarPaisIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox AgregarCiudadIconPictureBox;
        private FontAwesome.Sharp.IconPictureBox AgregarPaisIconPictureBox;
        private System.Windows.Forms.ComboBox CiudadesComboBox;
        private System.Windows.Forms.ComboBox PaisesComboBox;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.TextBox ProveedorTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox CodPostalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}