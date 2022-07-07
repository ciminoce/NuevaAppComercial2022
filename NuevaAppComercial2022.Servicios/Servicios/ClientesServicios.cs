using System;
using System.Collections.Generic;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class ClientesServicios
    {
        private readonly ClientesRepositorio repositorio;

        public ClientesServicios()
        {
            repositorio=new ClientesRepositorio();
        }

        public List<Cliente> GetLista()
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
    }
}
