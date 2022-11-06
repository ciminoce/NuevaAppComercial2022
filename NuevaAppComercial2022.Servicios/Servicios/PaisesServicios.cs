using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class PaisesServicios
    {
        private PaisesRepositorio repositorio;

        public PaisesServicios()
        {
            
        }

        public List<Pais> GetLista()
        {
            try
            {
                List<Pais> lista = null;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);
                    lista = repositorio.GetLista();
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Pais pais)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);
                    registros = repositorio.Agregar(pais);
                }

                return registros;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int Borrar(Pais pais)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);

                    registros = repositorio.Borrar(pais);
                }

                return registros;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        public int Editar(Pais pais)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);

                    registros = repositorio.Editar(pais);
                }

                return registros;
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                bool existe=true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);

                    existe = repositorio.Existe(pais);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Pais pais)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);
                    estaRelacionado= repositorio.EstaRelacionado(pais);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad()
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);
                    registros = repositorio.GetCantidad();
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Pais> GetListaPaginada(int paginaActual, int registrosPorPagina)
        {
            try
            {
                List<Pais> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new PaisesRepositorio(cn);
                    lista = repositorio.GetListaPaginada(paginaActual,registrosPorPagina);

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
