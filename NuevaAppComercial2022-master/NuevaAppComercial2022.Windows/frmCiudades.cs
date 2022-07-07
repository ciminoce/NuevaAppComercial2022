using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        private CiudadesServicios servicio;
        private List<Ciudad> lista;
        private void frmCiudades_Load(object sender, System.EventArgs e)
        {
            servicio = new CiudadesServicios();
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
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
            foreach (var ciudad in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, ciudad);
                HelperGrid.AgregarFila(DatosDataGridView, r);
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmCiudadesAE frm = new frmCiudadesAE() { Text = "Agregar Ciudad" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Ciudad ciudad = frm.GetCiudad();
                int registrosAfectados = servicio.Agregar(ciudad);
                if (registrosAfectados == 0)
                {
                    HelperMessage.Mensaje(TipoMensaje.Warning, "No se agregaron registros", "Advertencia");
                    RecargarGrilla();
                }
                else
                {
                    DataGridViewRow r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, ciudad);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Registro agregado", "Mensaje");
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
                Ciudad c = (Ciudad)r.Tag;

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
            int registrosAfectados = 0;
            var r = DatosDataGridView.SelectedRows[0];
            Ciudad c = (Ciudad)r.Tag;
            Ciudad cAux = (Ciudad)c.Clone();

            try
            {
                
                frmCiudadesAE frm = new frmCiudadesAE() { Text = "Editar Ciudad" };
                frm.SetCiudad(c);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                c = frm.GetCiudad();
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
                HelperGrid.SetearFila(r,cAux);
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }

        }
    }
}
