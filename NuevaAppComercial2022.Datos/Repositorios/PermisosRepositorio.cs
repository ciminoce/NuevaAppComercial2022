using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class PermisosRepositorio
    {
        private SqlConnection cn;

        public PermisosRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Permiso> GetPermisosPorRol(int rolId)
        {
            List<Permiso> lista = new List<Permiso>();
            try
            {
                var cadenaComando = "SELECT PermisoId, RolId, NombreMenu, RowVersion FROM Permisos WHERE RolId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", rolId);
                using (var reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var permiso = ConstruirPermiso(reader);
                        lista.Add(permiso);
                    }
                }

                return lista;
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
                RowVersion = (byte[])reader[3]
            };
        }

    }
}
