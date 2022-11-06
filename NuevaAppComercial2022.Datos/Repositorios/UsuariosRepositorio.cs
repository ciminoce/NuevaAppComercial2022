using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class UsuariosRepositorio
    {
        private SqlConnection cn;


        public UsuariosRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public Usuario GetUsuario(string nombre, string clave)
        {
            Usuario usuario = null;
            try
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
                return usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
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
