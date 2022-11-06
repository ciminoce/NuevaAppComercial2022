using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class CiudadesServicios
    {
        private CiudadesRepositorio repositorio;
        private PaisesRepositorio repoPaises;
        public CiudadesServicios()
        {
        }

        //public List<Ciudad> GetLista()
        //{
        //    try
        //    {
        //        List<Ciudad> lista;
        //        using (var cn=ConexionBd.GetInstancia().AbrirConexion())
        //        {
        //            repositorio = new CiudadesRepositorio(cn);
        //            repoPaises = new PaisesRepositorio(cn);
        //            lista=repositorio.GetLista();
        //            foreach (var ciudad in lista)
        //            {
        //                ciudad.Pais = repoPaises.GetPaisPorId(ciudad.PaisId);
        //            }
        //        }

        //        return lista;

        //    }
        //    catch (Exception e)
        //    {

        //        throw new Exception(e.Message);
        //    }
        //}
        public List<Ciudad> GetLista(Pais pais=null)
        {
            try
            {
                List<Ciudad> lista;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);
                    repoPaises = new PaisesRepositorio(cn);
                    lista = repositorio.GetLista(pais);
                    foreach (var ciudad in lista)
                    {
                        ciudad.Pais = repoPaises.GetPaisPorId(ciudad.PaisId);
                    }
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        public int Agregar(Ciudad ciudad)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);

                    registros = repositorio.Agregar(ciudad);
                    
                }

                return registros;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Ciudad ciudad)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);

                    registros = repositorio.Borrar(ciudad);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Ciudad ciudad)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);

                    registros = repositorio.Editar(ciudad);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool Existe(Ciudad ciudad)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);

                    existe = repositorio.Existe(ciudad);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(Pais pais=null)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);
                    registros = repositorio.GetCantidad(pais);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Ciudad> GetListaPaginada(int paginaActual, int registrosPorPagina, Pais pais=null)
        {
            try
            {
                List<Ciudad> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CiudadesRepositorio(cn);
                    repoPaises = new PaisesRepositorio(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina, pais);
                    foreach (var ciudad in lista)
                    {
                        ciudad.Pais = repoPaises.GetPaisPorId(ciudad.PaisId);
                    }
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
