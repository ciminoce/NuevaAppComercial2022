using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevaAppComercial2022.Windows
{
    public partial class frmBuscarFecha : Form
    {
        public frmBuscarFecha()
        {
            InitializeComponent();
        }

        private DateTime fecha;
        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                fecha = FechaDateTimePicker.Value.Date;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (FechaDateTimePicker.Value.Date>DateTime.Today.Date)
            {
                valido = false;
                errorProvider1.SetError(FechaDateTimePicker,"Fecha superior a la actual");
            }

            return valido;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }
    }
}
