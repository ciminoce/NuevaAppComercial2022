
namespace NuevaAppComercial2022.Windows
{
    partial class frmClientesAE
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
            this.PaisesComboBox = new System.Windows.Forms.ComboBox();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.CodPostalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CiudadesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FijoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarPaisIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            this.AgregarCiudadIconPictureBox = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarPaisIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCiudadIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PaisesComboBox
            // 
            this.PaisesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisesComboBox.FormattingEnabled = true;
            this.PaisesComboBox.Location = new System.Drawing.Point(94, 114);
            this.PaisesComboBox.Name = "PaisesComboBox";
            this.PaisesComboBox.Size = new System.Drawing.Size(282, 21);
            this.PaisesComboBox.TabIndex = 2;
            this.PaisesComboBox.SelectedIndexChanged += new System.EventHandler(this.PaisesComboBox_SelectedIndexChanged);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(456, 217);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 59);
            this.CancelarIconButton.TabIndex = 6;
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
            this.OKIconButton.Location = new System.Drawing.Point(53, 217);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 59);
            this.OKIconButton.TabIndex = 5;
            this.OKIconButton.Text = "Guardar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // CodPostalTextBox
            // 
            this.CodPostalTextBox.Location = new System.Drawing.Point(523, 76);
            this.CodPostalTextBox.MaxLength = 10;
            this.CodPostalTextBox.Name = "CodPostalTextBox";
            this.CodPostalTextBox.Size = new System.Drawing.Size(95, 20);
            this.CodPostalTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "País:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cod. Postal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Cliente:";
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(94, 40);
            this.ClienteTextBox.MaxLength = 255;
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(282, 20);
            this.ClienteTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dirección:";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(94, 76);
            this.DireccionTextBox.MaxLength = 255;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(352, 20);
            this.DireccionTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ciudad:";
            // 
            // CiudadesComboBox
            // 
            this.CiudadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadesComboBox.FormattingEnabled = true;
            this.CiudadesComboBox.Location = new System.Drawing.Point(94, 150);
            this.CiudadesComboBox.Name = "CiudadesComboBox";
            this.CiudadesComboBox.Size = new System.Drawing.Size(282, 21);
            this.CiudadesComboBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CelularTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.FijoTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(418, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Teléfonos ";
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(61, 43);
            this.CelularTextBox.MaxLength = 20;
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(119, 20);
            this.CelularTextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Celular:";
            // 
            // FijoTextBox
            // 
            this.FijoTextBox.Location = new System.Drawing.Point(61, 17);
            this.FijoTextBox.MaxLength = 20;
            this.FijoTextBox.Name = "FijoTextBox";
            this.FijoTextBox.Size = new System.Drawing.Size(119, 20);
            this.FijoTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tel. Fijo:";
            // 
            // AgregarPaisIconPictureBox
            // 
            this.AgregarPaisIconPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.AgregarPaisIconPictureBox.ForeColor = System.Drawing.Color.Lime;
            this.AgregarPaisIconPictureBox.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.AgregarPaisIconPictureBox.IconColor = System.Drawing.Color.Lime;
            this.AgregarPaisIconPictureBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AgregarPaisIconPictureBox.IconSize = 31;
            this.AgregarPaisIconPictureBox.Location = new System.Drawing.Point(381, 110);
            this.AgregarPaisIconPictureBox.Name = "AgregarPaisIconPictureBox";
            this.AgregarPaisIconPictureBox.Size = new System.Drawing.Size(31, 34);
            this.AgregarPaisIconPictureBox.TabIndex = 15;
            this.AgregarPaisIconPictureBox.TabStop = false;
            this.AgregarPaisIconPictureBox.Click += new System.EventHandler(this.AgregarPaisIconPictureBox_Click);
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
            this.AgregarCiudadIconPictureBox.Location = new System.Drawing.Point(381, 150);
            this.AgregarCiudadIconPictureBox.Name = "AgregarCiudadIconPictureBox";
            this.AgregarCiudadIconPictureBox.Size = new System.Drawing.Size(31, 34);
            this.AgregarCiudadIconPictureBox.TabIndex = 15;
            this.AgregarCiudadIconPictureBox.TabStop = false;
            this.AgregarCiudadIconPictureBox.Click += new System.EventHandler(this.AgregarCiudadIconPictureBox_Click);
            // 
            // frmClientesAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 288);
            this.Controls.Add(this.AgregarCiudadIconPictureBox);
            this.Controls.Add(this.AgregarPaisIconPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CiudadesComboBox);
            this.Controls.Add(this.PaisesComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.ClienteTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.CodPostalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientesAE";
            this.Text = "frmClientesAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarPaisIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarCiudadIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PaisesComboBox;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.TextBox CodPostalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClienteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CiudadesComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FijoTextBox;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox AgregarPaisIconPictureBox;
        private FontAwesome.Sharp.IconPictureBox AgregarCiudadIconPictureBox;
    }
}