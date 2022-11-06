
namespace NuevaAppComercial2022.Windows
{
    partial class frmBuscarPaisCiudad
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
            this.label2 = new System.Windows.Forms.Label();
            this.CiudadesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PaisesComboBox
            // 
            this.PaisesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaisesComboBox.FormattingEnabled = true;
            this.PaisesComboBox.Location = new System.Drawing.Point(90, 38);
            this.PaisesComboBox.Name = "PaisesComboBox";
            this.PaisesComboBox.Size = new System.Drawing.Size(282, 21);
            this.PaisesComboBox.TabIndex = 21;
            this.PaisesComboBox.SelectedIndexChanged += new System.EventHandler(this.PaisesComboBox_SelectedIndexChanged);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(251, 123);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 59);
            this.CancelarIconButton.TabIndex = 19;
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
            this.OKIconButton.Location = new System.Drawing.Point(44, 123);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 59);
            this.OKIconButton.TabIndex = 20;
            this.OKIconButton.Text = "OK";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "País:";
            // 
            // CiudadesComboBox
            // 
            this.CiudadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadesComboBox.FormattingEnabled = true;
            this.CiudadesComboBox.Location = new System.Drawing.Point(90, 71);
            this.CiudadesComboBox.Name = "CiudadesComboBox";
            this.CiudadesComboBox.Size = new System.Drawing.Size(282, 21);
            this.CiudadesComboBox.TabIndex = 24;
            this.CiudadesComboBox.SelectedIndexChanged += new System.EventHandler(this.CiudadesComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ciudad:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBuscarPaisCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 197);
            this.ControlBox = false;
            this.Controls.Add(this.CiudadesComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PaisesComboBox);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.label2);
            this.Name = "frmBuscarPaisCiudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Pais y Ciudad";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PaisesComboBox;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CiudadesComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}