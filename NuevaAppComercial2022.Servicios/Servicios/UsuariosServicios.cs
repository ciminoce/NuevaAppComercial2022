using System;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class UsuariosServicios
    {
        private readonly UsuariosRepositorio repositorio;

        public UsuariosServicios()
        {
            repositorio=new UsuariosRepositorio();
        }

        public Usuario GetUsuario(string nombre, string clave)
        {
            try
            {
                var usuario = repositorio.GetUsuario(nombre, clave);
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
