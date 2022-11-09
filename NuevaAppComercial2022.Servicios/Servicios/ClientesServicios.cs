using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class ClientesServicios
    {
        private ClientesRepositorio repositorio;
        private PaisesRepositorio repoPais;
        private CiudadesRepositorio repoCiudad;

        public ClientesServicios()
        {
        }

        public List<Cliente> GetLista()
        {
            try
            {
                List<Cliente> lista = null;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);
                    repoPais = new PaisesRepositorio(cn);
                    repoCiudad = new CiudadesRepositorio(cn);
                    lista= repositorio.GetLista();
                    foreach (var cliente in lista)
                    {
                        cliente.Pais = repoPais.GetPaisPorId(cliente.PaisId);
                        cliente.Ciudad = repoCiudad.GetCiudadPorId(cliente.CiudadId);
                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);

                    existe = repositorio.Existe(cliente);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);

                    registros = repositorio.Agregar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);
                    estaRelacionado = repositorio.EstaRelacionado(cliente);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Borrar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);

                    registros = repositorio.Borrar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Cliente cliente)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);

                    registros = repositorio.Editar(cliente);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Cliente> GetListaPaginada(int paginaActual, int registrosPorPagina, Pais pais=null, Ciudad ciudad=null)
        {
            try
            {
                List<Cliente> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);
                    repoPais = new PaisesRepositorio(cn);
                    repoCiudad = new CiudadesRepositorio(cn);
                    lista = repositorio.GetListaPaginada(paginaActual, registrosPorPagina, pais, ciudad);
                    foreach (var cliente in lista)
                    {
                        cliente.Pais = repoPais.GetPaisPorId(cliente.PaisId);
                        cliente.Ciudad = repoCiudad.GetCiudadPorId(cliente.CiudadId);
                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(Pais pais=null, Ciudad ciudad=null)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);
                    registros = repositorio.GetCantidad(pais,ciudad);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ClientesRepositorio(cn);
                    return repositorio.GetClientePorId(id);
                }


                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
