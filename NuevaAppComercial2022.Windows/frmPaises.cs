using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmPaises : Form
    {
        public frmPaises()
        {
            InitializeComponent();
        }

        private PaisesServicios servicio;
        private List<Pais> lista;

        private int cantidadPaginas;
        private int registrosPorPagina = 10;
        private int paginaActual=1;


        private void frmPaises_Load(object sender, EventArgs e)
        {
            servicio = new PaisesServicios();
            cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(), registrosPorPagina);
            TotalPaginasTextBox.Text = cantidadPaginas.ToString();
            PaginasComboBox.DataSource = HelperCombos.CargarDatosComboPaginas(cantidadPaginas);
            RecargarGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            //DatosDataGridView.Rows.Clear();
            HelperGrid.LimpiarGrilla(DatosDataGridView);
            foreach (var pais in lista)
            {
                //DataGridViewRow r = ConstruirFila();
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                //SetearFila(r, pais);
                HelperGrid.SetearFila(r, pais);
                //AgregarFila(r);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }


        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmPaisesAE frm = new frmPaisesAE() { Text = "Agregar un país" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Pais pais = frm.GetPais();
                if (!servicio.Existe(pais))
                {
                    int registrosAfectados = servicio.Agregar(pais);
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
                        var r = HelperGrid.ConstruirFila(DatosDataGridView);
                        HelperGrid.SetearFila(r, pais);
                        HelperGrid.AgregarFila(DatosDataGridView, r);
                        MessageBox.Show("Registro agregado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    }

                }
                else
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "País existente!!!", "Error");
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
                lista = servicio.GetListaPaginada(paginaActual,registrosPorPagina);
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
                Pais pais = (Pais)r.Tag;
                DialogResult dr = MessageBox.Show($"¿Desea borrar el registro seleccionado de {pais.NombrePais}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(pais))
                {
                    int registrosAfectados = servicio.Borrar(pais);
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
                else
                {
                    HelperMessage.Mensaje(TipoMensaje.Error,
                        "Registro relacionado..." + Environment.NewLine + "Baja denegada!!!",
                        "Error");
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
            Pais pais = (Pais)r.Tag;
            Pais paisAuxiliar = (Pais)pais.Clone();
            try
            {
                frmPaisesAE frm = new frmPaisesAE() { Text = "Editar un país" };
                frm.SetPais(pais);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                pais = frm.GetPais();
                if (!servicio.Existe(pais))
                {
                    int registrosAfectados = servicio.Editar(pais);
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
                        //SetearFila(r,pais);
                        HelperGrid.SetearFila(r, pais);
                        MessageBox.Show("Registro modificado",
                            "Mensaje",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                }
                else
                {
                    HelperGrid.SetearFila(r,paisAuxiliar);
                    HelperMessage.Mensaje(TipoMensaje.Error, "País existente!!!", "Error");
                }
            }
            catch (Exception exception)
            {
                //SetearFila(r, paisAuxiliar);
                HelperGrid.SetearFila(r, paisAuxiliar);
                MessageBox.Show(exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PaginasComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            paginaActual = int.Parse(PaginasComboBox.Text);
            RecargarGrilla();
        }
    }
}
