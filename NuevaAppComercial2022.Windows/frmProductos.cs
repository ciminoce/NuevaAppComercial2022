using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private ProductosServicios servicio;
        private List<Producto> lista;

        private int cantidadPaginas;
        private int registrosPorPagina = 10;
        private int paginaActual = 1;
        private void frmProductos_Load(object sender, System.EventArgs e)
        {
            servicio = new ProductosServicios();
            cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(categoria), registrosPorPagina);
            TotalPaginasTextBox.Text = cantidadPaginas.ToString();
            PaginasComboBox.DataSource = HelperCombos.CargarDatosComboPaginas(cantidadPaginas);
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina,categoria);
                //MostrarDatosEnGrilla();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception e)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, e.Message, "Error");
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var producto in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, producto);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmProductosAE frm = new frmProductosAE() { Text = "Agregar Producto" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Producto producto = frm.GetProducto();
                if (!servicio.Existe(producto))
                {
                    int registrosAfectados = servicio.Agregar(producto);
                    if (registrosAfectados == 0)
                    {
                        HelperMessage.Mensaje(TipoMensaje.Warning, "No se agregaron registros", "Advertencia");
                        RecargarGrilla();
                    }
                    else
                    {
                        //DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                        //HelperGrid.SetearFila(r, producto);
                        //HelperGrid.AgregarFila(DatosDataGridView, r);
                        cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(categoria), registrosPorPagina);
                        TotalPaginasTextBox.Text = cantidadPaginas.ToString();
                        PaginasComboBox.DataSource = HelperCombos.CargarDatosComboPaginas(cantidadPaginas);
                        RecargarGrilla();

                        HelperMessage.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
                    }

                }
                else
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Producto existente!!!", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                int registrosAfectados = 0;
                var r = DatosDataGridView.SelectedRows[0];
                Producto c = (Producto)r.Tag;

                DialogResult dr = HelperMessage.Mensaje("¿Desea borrar el registro seleccionado?", "Confirmar Baja");
                if (dr == DialogResult.No)
                {
                    return;
                }


                registrosAfectados = servicio.Borrar(c);
                if (registrosAfectados == 0)
                {

                    HelperMessage.Mensaje(TipoMensaje.Warning, "No se pudieron borrar registros", "Mensaje");

                }
                else
                {
                    DatosDataGridView.Rows.Remove(r);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro eliminado", "Mensaje");

                }
            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }

        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }
            try
            {
                int registrosAfectados = 0;
                var r = DatosDataGridView.SelectedRows[0];
                Producto c = (Producto)r.Tag;
                c = servicio.GetProductoPorId(c.ProductoId);
                Producto cAux = (Producto)c.Clone();


                frmProductosAE frm = new frmProductosAE() { Text = "Editar Producto" };
                frm.SetProducto(c);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                c = frm.GetProducto();
                registrosAfectados = servicio.Editar(c);
                if (registrosAfectados == 0)
                {

                    HelperMessage.Mensaje(TipoMensaje.Warning, "Registro editado", "Mensaje");

                }
                else
                {
                    HelperGrid.SetearFila(r, c);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro editado", "Mensaje");

                }
            }
            catch (Exception exception)
            {
                RecargarGrilla();
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }

        }

        private Categoria categoria;
        private void FiltroIconButton_Click(object sender, EventArgs e)
        {
            //if (FiltroIconButton.BackColor == Color.RoyalBlue)
            //{
            //    try
            //    {
            //        frmBuscarCategoria frm = new frmBuscarCategoria() { Text = "Seleccione País" };
            //        DialogResult dr = frm.ShowDialog(this);
            //        if (dr == DialogResult.Cancel)
            //        {
            //            return;
            //        }
            //        pais = frm.GetPais();

            //        cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(pais), registrosPorPagina);
            //        TotalPaginasTextBox.Text = cantidadPaginas.ToString();
            //        PaginasComboBox.DataSource = HelperCombos.CargarDatosComboPaginas(cantidadPaginas);
            //        paginaActual = 1;

            //        lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina, pais);
            //        HelperForm.MostrarDatosEnGrilla<Producto>(DatosDataGridView, lista);
            //        FiltroIconButton.BackColor = Color.OrangeRed;
            //    }
            //    catch (Exception exception)
            //    {
            //        throw exception;
            //    }

            //}
            //else
            //{
            //    try
            //    {
            //        cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(), registrosPorPagina);
            //        TotalPaginasTextBox.Text = cantidadPaginas.ToString();
            //        PaginasComboBox.DataSource = HelperCombos.CargarDatosComboPaginas(cantidadPaginas);
            //        paginaActual = 1;
            //        lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina, null);
            //        HelperForm.MostrarDatosEnGrilla<Producto>(DatosDataGridView, lista);
            //        FiltroIconButton.BackColor = Color.RoyalBlue;
            //    }
            //    catch (Exception exception)
            //    {
            //        throw exception;
            //    }

            //}
        }

        private void PaginasComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (FiltroIconButton.BackColor == Color.RoyalBlue)
            {
                paginaActual = int.Parse(PaginasComboBox.Text);
                RecargarGrilla();

            }
            else
            {
                paginaActual = int.Parse(PaginasComboBox.Text);
                lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina, categoria);
                HelperForm.MostrarDatosEnGrilla<Producto>(DatosDataGridView, lista);

            }
        }

    }
}
