using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;
using NuevaAppComercial2022.Windows.Helpers;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private ClientesServicios servicio;
        private List<Cliente> lista;

        private int cantidadPaginas;
        private int registrosPorPagina = 10;
        private int paginaActual = 1;

        private Pais pais;
        private Ciudad ciudad;


        private void frmClientes_Load(object sender, EventArgs e)
        {
            servicio=new ClientesServicios();
            paginaActual = 1;
            cantidadPaginas=HelperCalculos.CantidadPaginas(servicio.GetCantidad(pais, ciudad),registrosPorPagina);
           
            RecargarGrilla();
            ManejoBotonesNavegacion();

        }

        private void ManejoBotonesNavegacion()
        {
            if (paginaActual==1)
            {
                AnteriorIconButton.Enabled = false;
                SiguienteIconButton.Enabled = true;
            }else if (paginaActual==cantidadPaginas)
            {
                AnteriorIconButton.Enabled = true;
                SiguienteIconButton.Enabled = false;
            }
            else
            {
                AnteriorIconButton.Enabled = true;
                SiguienteIconButton.Enabled = true;
            }
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = servicio.GetListaPaginada(paginaActual,registrosPorPagina,pais,ciudad);
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView,lista);
            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmClientesAE frm = new frmClientesAE() { Text = "Nuevo Cliente" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;

            }

            try
            {
                Cliente cliente = frm.GetCliente();
                if (servicio.Existe(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente existente!!!", "ERROR");
                }
                else
                {
                    int registors=servicio.Agregar(cliente);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Cliente agregado!!!", "Mensaje");
                    var r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r,cliente);
                    HelperGrid.AgregarFila(DatosDataGridView,r);
                }

            }
            catch (Exception ex)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count==0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            Cliente cliente = (Cliente)r.Tag;
            DialogResult dr = HelperMessage.Mensaje("¿Desea borrar el cliente?", "Confirmar");
            if (dr==DialogResult.No)
            {
                return;
            }

            try
            {
                if (servicio.EstaRelacionado(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente relacionado!!", "ERROR");
                }
                else
                {
                    int registros=servicio.Editar(cliente);
                    if (registros==0)
                    {
                        HelperMessage.Mensaje(TipoMensaje.Warning, "No se editaron registros", "Advertencia");
                    }
                    else
                    {
                        HelperGrid.BorrarFila(DatosDataGridView, r);
                        
                        HelperMessage.Mensaje(TipoMensaje.OK, "Cliente borrado", "Mensaje");
                    }
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

            var r = DatosDataGridView.SelectedRows[0];
            Cliente cliente = (Cliente)r.Tag;
            frmClientesAE frm = new frmClientesAE() { Text = "Editar Cliente" };
            frm.SetCliente(cliente);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;

            }

            try
            {
                cliente = frm.GetCliente();
                if (servicio.Existe(cliente))
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, "Cliente existente!!!", "ERROR");
                }
                else
                {
                    int registors = servicio.Editar(cliente);
                    HelperMessage.Mensaje(TipoMensaje.OK, "Cliente editado!!!", "Mensaje");
                    r = HelperGrid.ConstruirFila(DatosDataGridView);
                    HelperGrid.SetearFila(r, cliente);
                }

            }
            catch (Exception exception)
            {
                HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }

        }

        private void FiltrarIconButton_Click(object sender, EventArgs e)
        {
            if (FiltroIconButton.BackColor == Color.RoyalBlue)
            {
                try
                {
                    frmBuscarPaisCiudad frm = new frmBuscarPaisCiudad() { Text = "Seleccione País y Ciudad" };
                    DialogResult dr = frm.ShowDialog(this);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    pais = frm.GetPais();
                    ciudad = frm.GetCiudad();
                    paginaActual = 1;
                    //cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(pais, ciudad), registrosPorPagina);

                    //lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina, pais,ciudad);
                    //HelperForm.MostrarDatosEnGrilla<Cliente>(DatosDataGridView, lista);
                    RecargarGrilla();
                    ManejoBotonesNavegacion();
                    FiltroIconButton.BackColor = Color.OrangeRed;
                }
                catch (Exception exception)
                {
                    HelperMessage.Mensaje(TipoMensaje.Error, exception.Message, "Error");
                }

            }
            else
            {
                try
                {
                    pais = null;
                    ciudad = null;
                    paginaActual = 1;
                    //cantidadPaginas = HelperCalculos.CantidadPaginas(servicio.GetCantidad(), registrosPorPagina);
                    //lista = servicio.GetListaPaginada(paginaActual, registrosPorPagina, null,null);
                    //HelperForm.MostrarDatosEnGrilla<Cliente>(DatosDataGridView, lista);
                    RecargarGrilla();
                    ManejoBotonesNavegacion();
                    FiltroIconButton.BackColor = Color.RoyalBlue;
                }
                catch (Exception exception)
                {
                    throw exception;
                }

            }

        }

        private void SiguienteIconButton_Click(object sender, EventArgs e)
        {
            paginaActual++;
            if (paginaActual>cantidadPaginas)
            {
                paginaActual = cantidadPaginas;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void UltimoIconButton_Click(object sender, EventArgs e)
        {
            paginaActual = cantidadPaginas;
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void AnteriorIconButton_Click(object sender, EventArgs e)
        {
            paginaActual--;
            if (paginaActual<1)
            {
                paginaActual = 1;
            }
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void PrimeroIconButton_Click(object sender, EventArgs e)
        {
            paginaActual = 1;
            RecargarGrilla();
            ManejoBotonesNavegacion();
        }

        private void BuscarIconButton_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
