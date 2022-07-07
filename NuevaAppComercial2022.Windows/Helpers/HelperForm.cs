using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Forms;

namespace NuevaAppComercial2022.Windows.Helpers
{
    public static class HelperForm
    {
        public static void MostrarDatosEnGrilla<T>(DataGridView dataGrid, List<T> lista)
        {
            HelperGrid.LimpiarGrilla(dataGrid);
            foreach (var obj in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(dataGrid);
                HelperGrid.SetearFila(r, obj);
                HelperGrid.AgregarFila(dataGrid, r);
            }
        }

    }
}
