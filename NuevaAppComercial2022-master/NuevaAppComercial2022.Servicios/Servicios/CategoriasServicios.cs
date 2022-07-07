using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class CategoriasServicios
    {
        private readonly CategoriasRepositorio repositorio;

        public CategoriasServicios()
        {
            repositorio = new CategoriasRepositorio();
        }

        public List<Categoria> GetLista()
        {
            try
            {
                return repositorio.GetLista();
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
                return repositorio.Agregar(categoria);
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
                return repositorio.Borrar(categoria);
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
                return repositorio.Editar(categoria);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
