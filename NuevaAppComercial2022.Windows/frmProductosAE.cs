using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmProductosAE : Form
    {
        private string imagenNoDisponible = Environment.CurrentDirectory + @"\Imagenes\SinImagenDisponible.jpg";
        private string archivoNoEncontrado = Environment.CurrentDirectory + @"\Imagenes\ArchivoNoEncontrado.jpg";
        private string archivoImagen = string.Empty;
        public frmProductosAE()
        {
            InitializeComponent();
        }

        private Producto producto;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombos.CargarDatosComboCategorias(ref CategoriasComboBox);
            HelperCombos.CargarDatosComboProveedores(ref ProveedoresComboBox);
            if (producto != null)
            {
                ProductoTextBox.Text = producto.NombreProducto;
                PrecioVtaTextBox.Text = producto.PrecioUnitario.ToString();
                StockNumericUpDown.Value = producto.Stock;
                CategoriasComboBox.SelectedValue = producto.CategoriaId;
                ProveedoresComboBox.SelectedValue = producto.ProveedorId;
                MinimoNmericUpDown.Value = producto.StockMinimo;
                SuspendidoCheckBox.Checked = producto.Suspendido;
                //Veo si el producto tiene alguna imagen asociada
                if (producto.Imagen != string.Empty)
                {
                    //Me aseguro que esa imagen exista
                    if (!File.Exists(producto.Imagen))
                    {
                        //Si no existe, muestro la imagen de archivo no encontrado
                        ImagenPictureBox.Image = Image.FromFile(archivoNoEncontrado);
                    }
                    else
                    {
                        //Caso contrario muestro la imagen
                        ImagenPictureBox.Image = Image.FromFile(producto.Imagen);
                    }
                }
                else
                {
                    //Si no tiene imagen muestro Sin Imagen 
                    ImagenPictureBox.Image = Image.FromFile(imagenNoDisponible);
                }
            }
        }

        public Producto GetProducto()
        {
            return producto;
        }

        public void SetProducto(Producto producto)
        {
            this.producto = producto;
        }

        private void BuscarIconButton_Click(object sender, EventArgs e)
        {
            //Seteo del openFileDialog
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory + @"\Imagenes\";
            openFileDialog1.Filter = "Archivos jpg (*.jpg)|*.jpg|Archivos png (*.png)|*.png|Archivos jfif (*.jfif)|*.jfif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            DialogResult dr = openFileDialog1.ShowDialog(this);//muestro el openFileDialog

            if (dr == DialogResult.OK)
            {
                //Veo si tengo algun imagen seleccionada
                if (openFileDialog1.FileName == null)
                {
                    return;//sino me voy
                }
                //Tomo el nombre del archivo de imagen con su ruta
                //archivoNombreConRuta = openFileDialog1.FileName;
                ImagenPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                archivoImagen = openFileDialog1.FileName;//Tomo la ruta y el nombre del archivo
            }

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (producto == null)
                {
                    producto = new Producto();
                }

                producto.NombreProducto = ProductoTextBox.Text;
                producto.CategoriaId =(int) CategoriasComboBox.SelectedValue;
                producto.ProveedorId = (int) ProveedoresComboBox.SelectedValue;
                producto.Stock = (int) StockNumericUpDown.Value;
                producto.StockMinimo = (int) MinimoNmericUpDown.Value;
                producto.PrecioUnitario = decimal.Parse(PrecioVtaTextBox.Text);
                producto.Suspendido = SuspendidoCheckBox.Checked;
                producto.Imagen = archivoImagen;

                DialogResult = DialogResult.OK;

            }
        }

        private bool ValidarDatos()
        {
            return true;
        }
    }
}
