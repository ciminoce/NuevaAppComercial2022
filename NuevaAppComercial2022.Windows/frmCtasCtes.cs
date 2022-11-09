using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmCtasCtes : Form
    {
        public frmCtasCtes()
        {
            InitializeComponent();
        }

        private CtaCteServicio servicio;
        private List<CtaCte> lista;
        private void frmCtasCtes_Load(object sender, EventArgs e)
        {
            servicio = new CtaCteServicio();
            this.Dock = DockStyle.Fill;
            try
            {
                lista = servicio.GetSaldos();
                MostrarDatosGrilla(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MostrarDatosGrilla(List<CtaCte> lista)
        {
            dgvDatos.Rows.Clear();
            foreach (var item in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r);
            }
        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, CtaCte item)
        {
            r.Cells[cmnCliente.Index].Value = item.Cliente.Nombre;
            r.Cells[cmnSaldo.Index].Value = item.Saldo;
            if (item.Saldo > 0)
            {
                r.Cells[cmnSaldo.Index].Style.BackColor = Color.Red;
            }
            else if (item.Saldo <= 0)
            {
                r.Cells[cmnSaldo.Index].Style.BackColor = Color.Green;

            }
            r.Tag = item;
        }


        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                frmDetalleCtaCte frm = new frmDetalleCtaCte();
                frm.Text = "Detalle de Cta. Cte";
                DataGridViewRow r = dgvDatos.CurrentRow;
                var cta = (CtaCte)r.Tag;
                List<CtaCte> listaMovimientosCtaCte = servicio.GetLista(cta.ClienteId);
                frm.SetCtaCte(listaMovimientosCtaCte);
                DialogResult dr = frm.ShowDialog(this);
            }

        }
    }
}
