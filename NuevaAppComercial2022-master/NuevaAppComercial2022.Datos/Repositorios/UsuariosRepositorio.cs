using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class UsuariosRepositorio
    {
        private readonly ConexionBd conexionBd;

        public UsuariosRepositorio()
        {
            conexionBd=new ConexionBd();
        }

        public Usuario GetUsuario(string nombre, string clave)
        {
            Usuario usuario = null;
            try
            {
                using (var cn=conexionBd.AbrirConexion())
                {
                    string cadenaComando =
                        "SELECT UsuarioId, NombreUsuario, Clave, RolId, Activo, RowVersion FROM Usuarios WHERE NombreUsuario=@usu AND Clave=@clave";
                    SqlCommand comando=new SqlCommand(cadenaComando,cn);
                    comando.Parameters.AddWithValue("@usu", nombre);
                    comando.Parameters.AddWithValue("@clave", clave);
                    using (var reader=comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            usuario = ConstruirUsuario(reader);
                        }
                    }

                    SetRol(cn, usuario);
                }

                return usuario;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void SetRol(SqlConnection cn, Usuario usuario)
        {
            Rol rol = null;
            try
            {
                var cadenaComando = "SELECT RolId, Descripcion, RowVersion FROM Roles WHERE RolId=@id";
                var comando=new SqlCommand(cadenaComando,cn);
                comando.Parameters.AddWithValue("@id", usuario.RolId);
                using (var reader=comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        rol = ConstruirRol(reader);
                    }
                }

                SetPermisos(rol, cn);
                usuario.Rol = rol;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void SetPermisos(Rol rol, SqlConnection cn)
        {
            List<Permiso> lista = new List<Permiso>();
            try
            {
                var cadenaComando = "SELECT PermisoId, RolId, NombreMenu, RowVersion FROM Permisos WHERE RolId=@id";
                var comando=new SqlCommand(cadenaComando,cn);
                comando.Parameters.AddWithValue("@id", rol.RolId);
                using (var reader=comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var permiso = ConstruirPermiso(reader);
                        lista.Add(permiso);
                    }
                }

                rol.Permisos = lista;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }
        }

        private Permiso ConstruirPermiso(SqlDataReader reader)
        {
            return new Permiso()
            {
                PermisoId = reader.GetInt32(0),
                RolId = reader.GetInt32(1),
                NombreMenu = reader.GetString(2),
                RowVersion = (byte[]) reader[3]
            };
        }

        private Rol ConstruirRol(SqlDataReader reader)
        {
            return new Rol()
            {
                RolId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[]) reader[2]
            };
        }

        private Usuario ConstruirUsuario(SqlDataReader reader)
        {
            Usuario usuario=new Usuario();
            usuario.UsuarioId = reader.GetInt32(0);
            usuario.NombreUsuario = reader.GetString(1);
            usuario.Clave = reader.GetString(2);
            usuario.RolId = reader.GetInt32(3);
            usuario.Activo = reader.GetBoolean(4);
            usuario.RowVersion = (byte[]) reader[5];
            return usuario;
        }
    }
}
