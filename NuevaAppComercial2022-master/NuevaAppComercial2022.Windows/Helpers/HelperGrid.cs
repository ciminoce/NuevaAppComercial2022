using System;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r=new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Pais p:
                    r.Cells[0].Value = ((Pais)obj).NombrePais;

                    break;
                case Categoria c:
                    r.Cells[0].Value = ((Categoria)obj).NombreCategoria;
                    r.Cells[1].Value = ((Categoria)obj).Descripcion;

                    break;
                case Ciudad ciudad:
                    r.Cells[0].Value = ((Ciudad)obj).Pais.NombrePais;
                    r.Cells[1].Value = ((Ciudad)obj).NombreCiudad;

                    break;
                case Cliente cliente:
                    r.Cells[0].Value = ((Cliente)obj).NombreCliente;
                    r.Cells[1].Value = ((Cliente)obj).Direccion;
                    r.Cells[2].Value = ((Cliente)obj).Pais.NombrePais;
                    r.Cells[3].Value = ((Cliente)obj).Ciudad.NombreCiudad;
                    r.Cells[4].Value = ((Cliente)obj).CodPostal;

                    break;

            }

            r.Tag = obj;

        }
    }
}
