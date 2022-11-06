using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        private ProveedoresServicios servicio;
        private List<Proveedor> lista;
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            servicio = new ProveedoresServicios();
            lista = servicio.GetLista();
            RecargarGrilla();

        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmProveedoresAE frm = new frmProveedoresAE() { Text = "Nuevo Proveedor" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                Proveedor proveedor = frm.GetProveedor();
                if (servicio.Existe(proveedor))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Proveedor existente!!!", "ERROR");
                }
                else
                {
                    int registors = servicio.Agregar(proveedor);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Proveedor agregado!!!", "Mensaje");
                    var r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, proveedor);
                    HelperGrid.AgregarFila(DatosDataGridView, r);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Proveedor proveedor = (Proveedor)r.Tag;
            DialogResult dr = HelperMessage.Mensaje("¿Desea borrar el proveedor?", "Confirmar");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (servicio.EstaRelacionado(proveedor))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Proveedor relacionado!!", "ERROR");
                }
                else
                {
                    int registros = servicio.Borrar(proveedor);
                    if (registros == 0)
                    {
                        HelperMessage.Mensaje(TipoMensaje.Warning, "No se borraron registros", "Advertencia");
                    }
                    else
                    {
                        HelperGrid.BorrarFila(DatosDataGridView, r);

                        HelperMessage.Mensaje(TipoMensaje.OK, "Proveedor borrado", "Mensaje");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

    }
}
