using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class CiudadesServicios
    {
        private readonly CiudadesRepositorio repositorio;

        public CiudadesServicios()
        {
            repositorio=new CiudadesRepositorio();
        }

        public List<Ciudad> GetLista()
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

        public int Agregar(Ciudad ciudad)
        {
            try
            {
                return repositorio.Agregar(ciudad);
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
                return repositorio.Borrar(ciudad);
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
                return repositorio.Editar(ciudad);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
