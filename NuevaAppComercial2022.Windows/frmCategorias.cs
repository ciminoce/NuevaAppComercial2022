using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private CategoriasServicios servicio;
        private List<Categoria> lista;
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            servicio = new CategoriasServicios();
            try
            {
                lista = servicio.GetLista();
                //MostrarDatosEnGrilla();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);

            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var categoria in lista)
            {
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, categoria);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmCategoriasAE frm = new frmCategoriasAE() { Text = "Agregar un país" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Categoria categoria = frm.GetCategoria();
                int registrosAfectados = servicio.Agregar(categoria);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se agregaron registros...",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    //Recargar grilla
                    RecargarGrilla();
                }
                else
                {
                    //var r = ConstruirFila();
                    var r = HelperGrid.ConstruirFila(DatosDataGridView);
                    //SetearFila(r,categoria);
                    HelperGrid.SetearFila(r, categoria);
                    //AgregarFila(r);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                    MessageBox.Show("Registro agregado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var r = DatosDataGridView.SelectedRows[0];
                Categoria categoria = (Categoria)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar el registro seleccionado de {categoria.NombreCategoria}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                int registrosAfectados = servicio.Borrar(categoria);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se borraron registros...",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    //Recargar grilla
                    RecargarGrilla();

                }
                else
                {
                    DatosDataGridView.Rows.Remove(r);
                    MessageBox.Show("Registro eliminado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Categoria categoria = (Categoria)r.Tag;
            Categoria catAuxiliar = (Categoria)categoria.Clone();
            try
            {
                frmCategoriasAE frm = new frmCategoriasAE() { Text = "Editar un país" };
                frm.SetCategoria(categoria);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                categoria = frm.GetCategoria();
                int registrosAfectados = servicio.Editar(categoria);
                if (registrosAfectados == 0)
                {
                    MessageBox.Show("No se borraron registros...",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    //Recargar grilla
                    RecargarGrilla();

                }
                else
                {
                    //SetearFila(r,categoria);
                    HelperGrid.SetearFila(r, categoria);
                    MessageBox.Show("Registro modificado",
                        "Mensaje",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                //SetearFila(r, catAuxiliar);
                HelperGrid.SetearFila(r, catAuxiliar);
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ImprimirIonButton_Click(object sender, EventArgs e)
        {
            HelperImprimir.ImprimirListadoCategorias(servicio.GetLista());
        }
    }
}
