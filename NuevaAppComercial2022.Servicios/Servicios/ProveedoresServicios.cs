using NuevaAppComercial2022.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class ProveedoresServicios
    {
        private ProveedoresRepositorio repositorio;
        private PaisesRepositorio repoPais;
        private CiudadesRepositorio repoCiudad;

        public ProveedoresServicios()
        {
        }

        public List<Proveedor> GetLista()
        {
            try
            {
                List<Proveedor> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProveedoresRepositorio(cn);
                    repoPais = new PaisesRepositorio(cn);
                    repoCiudad = new CiudadesRepositorio(cn);
                    lista = repositorio.GetLista();
                    foreach (var proveedor in lista)
                    {
                        proveedor.Pais = repoPais.GetPaisPorId(proveedor.PaisId);
                        proveedor.Ciudad = repoCiudad.GetCiudadPorId(proveedor.CiudadId);
                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Proveedor proveedor)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProveedoresRepositorio(cn);

                    existe = repositorio.Existe(proveedor);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Proveedor proveedor)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProveedoresRepositorio(cn);

                    registros = repositorio.Agregar(proveedor);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProveedoresRepositorio(cn);
                    estaRelacionado = repositorio.EstaRelacionado(proveedor);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Borrar(Proveedor proveedor)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProveedoresRepositorio(cn);

                    registros = repositorio.Borrar(proveedor);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
