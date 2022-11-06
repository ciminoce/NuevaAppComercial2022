using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NuevaAppComercial2022.Windows.UserControls
{
    public partial class ucProducto : UserControl
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imagenes\ArchivoNoEncontrado.jpg";
        public ucProducto()
        {
            InitializeComponent();
        }

        public int ProductoId { get; set; }

        public string Descripcion
        {
            set
            {
                DescripcionLabel.Text = value;
            }
        }

        public string Stock
        {
            set
            {
                StockLabel.Text = value;
            }
        }

        public string Precio
        {
            set
            {
                PrecioLabel.Text = value;
            }
        }

        public string Imagen
        {
            set
            {
                if (value != string.Empty)
                {
                    //Me aseguro que esa imagen exista
                    if (!File.Exists(value))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        ImagenPictureBox.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        ImagenPictureBox.Image = Image.FromFile(value);
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }

            }
        }

        private void ucProducto_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void ucProducto_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
