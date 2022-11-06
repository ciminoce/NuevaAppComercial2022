
namespace NuevaAppComercial2022.Windows
{
    partial class frmCobro
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VisaButton = new System.Windows.Forms.Button();
            this.EfectivoButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VueltoLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ImporteRecibidoLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImporteLabel = new System.Windows.Forms.Label();
            this.OKIconButton = new FontAwesome.Sharp.IconButton();
            this.CancelarIconButton = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.VisaButton);
            this.groupBox2.Controls.Add(this.EfectivoButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(781, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medios de Pago";
            // 
            // button5
            // 
            this.button5.Image = global::NuevaAppComercial2022.Windows.Properties.Resources.diners_club_50px;
            this.button5.Location = new System.Drawing.Point(426, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 89);
            this.button5.TabIndex = 0;
            this.button5.Text = "Diners";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::NuevaAppComercial2022.Windows.Properties.Resources.american_express_50px;
            this.button4.Location = new System.Drawing.Point(324, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 89);
            this.button4.TabIndex = 0;
            this.button4.Text = "Amex";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::NuevaAppComercial2022.Windows.Properties.Resources.mastercard_50px;
            this.button3.Location = new System.Drawing.Point(223, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 89);
            this.button3.TabIndex = 0;
            this.button3.Text = "Master";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VisaButton
            // 
            this.VisaButton.Image = global::NuevaAppComercial2022.Windows.Properties.Resources.visa_50px;
            this.VisaButton.Location = new System.Drawing.Point(122, 55);
            this.VisaButton.Name = "VisaButton";
            this.VisaButton.Size = new System.Drawing.Size(83, 89);
            this.VisaButton.TabIndex = 0;
            this.VisaButton.Text = "Visa";
            this.VisaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.VisaButton.UseVisualStyleBackColor = true;
            // 
            // EfectivoButton
            // 
            this.EfectivoButton.Image = global::NuevaAppComercial2022.Windows.Properties.Resources.money_50px;
            this.EfectivoButton.Location = new System.Drawing.Point(24, 55);
            this.EfectivoButton.Name = "EfectivoButton";
            this.EfectivoButton.Size = new System.Drawing.Size(83, 89);
            this.EfectivoButton.TabIndex = 0;
            this.EfectivoButton.Text = "Efectivo";
            this.EfectivoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EfectivoButton.UseVisualStyleBackColor = true;
            this.EfectivoButton.Click += new System.EventHandler(this.EfectivoButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.VueltoLabel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(13, 446);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 100);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vuelto";
            // 
            // VueltoLabel
            // 
            this.VueltoLabel.BackColor = System.Drawing.Color.White;
            this.VueltoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VueltoLabel.Location = new System.Drawing.Point(6, 20);
            this.VueltoLabel.Name = "VueltoLabel";
            this.VueltoLabel.Size = new System.Drawing.Size(763, 59);
            this.VueltoLabel.TabIndex = 0;
            this.VueltoLabel.Text = "0.00";
            this.VueltoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ImporteRecibidoLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Importe a Recibido";
            // 
            // ImporteRecibidoLabel
            // 
            this.ImporteRecibidoLabel.BackColor = System.Drawing.Color.White;
            this.ImporteRecibidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteRecibidoLabel.Location = new System.Drawing.Point(6, 20);
            this.ImporteRecibidoLabel.Name = "ImporteRecibidoLabel";
            this.ImporteRecibidoLabel.Size = new System.Drawing.Size(763, 59);
            this.ImporteRecibidoLabel.TabIndex = 0;
            this.ImporteRecibidoLabel.Text = "0.00";
            this.ImporteRecibidoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ImporteLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importe a Cobrar";
            // 
            // ImporteLabel
            // 
            this.ImporteLabel.BackColor = System.Drawing.Color.White;
            this.ImporteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteLabel.Location = new System.Drawing.Point(6, 20);
            this.ImporteLabel.Name = "ImporteLabel";
            this.ImporteLabel.Size = new System.Drawing.Size(763, 59);
            this.ImporteLabel.TabIndex = 0;
            this.ImporteLabel.Text = "0.00";
            this.ImporteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OKIconButton
            // 
            this.OKIconButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.OKIconButton.ForeColor = System.Drawing.Color.White;
            this.OKIconButton.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.OKIconButton.IconColor = System.Drawing.Color.White;
            this.OKIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OKIconButton.Location = new System.Drawing.Point(281, 557);
            this.OKIconButton.Name = "OKIconButton";
            this.OKIconButton.Size = new System.Drawing.Size(121, 59);
            this.OKIconButton.TabIndex = 14;
            this.OKIconButton.Text = "Guardar";
            this.OKIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OKIconButton.UseVisualStyleBackColor = false;
            this.OKIconButton.Click += new System.EventHandler(this.OKIconButton_Click);
            // 
            // CancelarIconButton
            // 
            this.CancelarIconButton.BackColor = System.Drawing.Color.Red;
            this.CancelarIconButton.ForeColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.CancelarIconButton.IconColor = System.Drawing.Color.White;
            this.CancelarIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CancelarIconButton.Location = new System.Drawing.Point(408, 557);
            this.CancelarIconButton.Name = "CancelarIconButton";
            this.CancelarIconButton.Size = new System.Drawing.Size(121, 59);
            this.CancelarIconButton.TabIndex = 13;
            this.CancelarIconButton.Text = "Cerrar";
            this.CancelarIconButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelarIconButton.UseVisualStyleBackColor = false;
            this.CancelarIconButton.Click += new System.EventHandler(this.CancelarIconButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.OKIconButton);
            this.Controls.Add(this.CancelarIconButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCobro";
            this.Text = "frmCobro";
            this.Load += new System.EventHandler(this.frmCobro_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VisaButton;
        private System.Windows.Forms.Button EfectivoButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label VueltoLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ImporteRecibidoLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ImporteLabel;
        private FontAwesome.Sharp.IconButton OKIconButton;
        private FontAwesome.Sharp.IconButton CancelarIconButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}