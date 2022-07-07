using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class PaisesServicios
    {
        private readonly PaisesRepositorio repositorio;

        public PaisesServicios()
        {
            repositorio=new PaisesRepositorio();
            
        }

        public List<Pais> GetLista()
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

        public int Agregar(Pais pais)
        {
            try
            {
                return repositorio.Agregar(pais);
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
                return repositorio.Borrar(pais);
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
                return repositorio.Editar(pais);
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
                return repositorio.Existe(pais);
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
                return repositorio.EstaRelacionado(pais);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
