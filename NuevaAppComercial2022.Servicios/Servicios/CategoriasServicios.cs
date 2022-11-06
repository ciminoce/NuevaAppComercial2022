using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class CategoriasServicios : IDisposable
    {
        private CategoriasRepositorio repositorio;

        public CategoriasServicios()
        {
            
        }

        public List<Categoria> GetLista()
        {
            try
            {
                List<Categoria> lista;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CategoriasRepositorio(cn);
                    lista = repositorio.GetLista();
                }

                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int Agregar(Categoria categoria)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CategoriasRepositorio(cn);
                    registros = repositorio.Agregar(categoria);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Categoria categoria)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CategoriasRepositorio(cn);

                    registros = repositorio.Borrar(categoria);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Categoria categoria)
        {
            try
            {
                int registros = 0;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new CategoriasRepositorio(cn);

                    registros = repositorio.Editar(categoria);

                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Dispose()
        {
        }
    }
}
