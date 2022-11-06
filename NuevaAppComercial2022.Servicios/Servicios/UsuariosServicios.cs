using System;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class UsuariosServicios
    {
        private UsuariosRepositorio repositorio;
        private RolesRepositorio repoRoles;
        private PermisosRepositorio repoPermisos;

        public UsuariosServicios()
        {
            
        }

        public Usuario GetUsuario(string nombre, string clave)
        {
            try
            {
                Usuario usuario = null;
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new UsuariosRepositorio(cn);
                    repoRoles = new RolesRepositorio(cn);
                    repoPermisos = new PermisosRepositorio(cn);
                    usuario = repositorio.GetUsuario(nombre, clave);
                    usuario.Rol = repoRoles.GetRolPorId(usuario.RolId);
                    usuario.Rol.Permisos = repoPermisos.GetPermisosPorRol(usuario.RolId);
                }
                
                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
