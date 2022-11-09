using System;
using System.Diagnostics;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Windows.Helpers
{
    public static class HelperImprimir
    {
        public static void ImprimirVenta(Venta venta)
        {
            var rutaArchivo = Environment.CurrentDirectory + "\\Temp\\";
            var nombreArchivo = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            var completo = $"{rutaArchivo}{nombreArchivo}";


            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Factura.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", venta.Cliente.Nombre);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIRECCION", venta.Cliente.Direccion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", venta.FechaVenta.ToShortDateString());

            string filas = string.Empty;
           
            foreach (var item in venta.Detalles)
            {
                filas += "<tr>";
                filas += "<td>" + item.Cantidad.ToString() + "</td>";
                filas += "<td>" + item.Producto.NombreProducto + "</td>";
                filas += "<td>" + item.PrecioUnitario.ToString() + "</td>";
                filas += "<td>" + (item.Cantidad * item.PrecioUnitario).ToString() + "</td>";
                filas += "</tr>";
                
            }

            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", venta.Total.ToString());



            using (FileStream stream = new FileStream(completo, FileMode.Create))
            {
                //Creamos un nuevo documento y lo definimos como PDF
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                //Agregamos la imagen del banner al documento
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop,
                    System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(60, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                //img.SetAbsolutePosition(10,100);
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                pdfDoc.Add(img);


                //pdfDoc.Add(new Phrase("Hola Mundo"));
                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
                Process.Start($"{completo}");//Muestra la factura
            }

        }
    }
}
