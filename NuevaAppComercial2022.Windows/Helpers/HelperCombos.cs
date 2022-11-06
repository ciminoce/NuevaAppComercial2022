using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Servicios.Servicios;

namespace NuevaAppComercial2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboPaises(ref ComboBox combo)
        {
            PaisesServicios servicio = new PaisesServicios();
            var lista = servicio.GetLista();
            var defaultPais = new Pais()
            {
                PaisId = 0,
                NombrePais = "Seleccione País"
            };
            lista.Insert(0, defaultPais);
            combo.DataSource = lista;
            combo.DisplayMember = "NombrePais";
            combo.ValueMember = "PaisId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboClientes(ref ComboBox combo)
        {
            ClientesServicios servicio = new ClientesServicios();
            var lista = servicio.GetLista();
            var defaultCliente = new Cliente()
            {
                Id = 0,
                Nombre = "Seleccione Cliente"
            };
            lista.Insert(0, defaultCliente);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboCiudades(ref ComboBox combo, Pais pais)
        {
            CiudadesServicios servicio = new CiudadesServicios();
            var lista = servicio.GetLista(pais);
            var defaultCiudad = new Ciudad()
            {
                CiudadId = 0,
                NombreCiudad = "Seleccione Ciudad"
            };
            lista.Insert(0, defaultCiudad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCiudad";
            combo.ValueMember = "CiudadId";
            combo.SelectedIndex = 0;
        }

        public static List<int> CargarDatosComboPaginas(int cantidadPaginas)
        {
            List<int> nros = new List<int>();
            for (int i = 1; i <= cantidadPaginas; i++)
            {
                nros.Add(i);
            }

            return nros;
        }

        public static void CargarDatosComboCategorias(ref ComboBox combo)
        {
            CategoriasServicios servicio = new CategoriasServicios();
            var lista = servicio.GetLista();
            var defaultCategoria = new Categoria()
            {
                CategoriaId = 0,
                NombreCategoria = "Seleccione Categoría"
            };
            lista.Insert(0, defaultCategoria);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreCategoria";
            combo.ValueMember = "CategoriaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboProveedores(ref ComboBox combo)
        {
            ProveedoresServicios servicio = new ProveedoresServicios();
            var lista = servicio.GetLista();
            var defaultProveedor = new Proveedor()
            {
                Id = 0,
                Nombre = "Seleccione Proveedor"
            };
            lista.Insert(0, defaultProveedor);
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "Id";
            combo.SelectedIndex = 0;
        }
    }
}
