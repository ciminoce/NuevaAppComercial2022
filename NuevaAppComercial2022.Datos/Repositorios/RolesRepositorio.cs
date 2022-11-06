using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class RolesRepositorio
    {
        private SqlConnection cn;

        public RolesRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public Rol GetRolPorId(int id)
        {
            Rol rol = null;
            try
            {
                var cadenaComando = "SELECT RolId, Descripcion, RowVersion FROM Roles WHERE RolId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        rol = ConstruirRol(reader);
                    }
                }
                return rol;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        private Rol ConstruirRol(SqlDataReader reader)
        {
            return new Rol()
            {
                RolId = reader.GetInt32(0),
                Descripcion = reader.GetString(1),
                RowVersion = (byte[])reader[2]
            };
        }

    }
}
