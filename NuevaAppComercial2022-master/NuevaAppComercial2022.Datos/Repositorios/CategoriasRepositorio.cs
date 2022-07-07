using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class CategoriasRepositorio
    {
        private readonly ConexionBd conexionBd;

        public CategoriasRepositorio()
        {
            conexionBd = new ConexionBd();
        }

        public List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion, RowVersion FROM Categorias";
                    var comando = new SqlCommand(cadenaComando, cn);
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria categoria = ConstruirCategoria(reader);
                            lista.Add(categoria);
                        }
                    }
                }

                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        private Categoria ConstruirCategoria(SqlDataReader reader)
        {
            return new Categoria()
            {
                CategoriaId = reader.GetInt32(0),
                NombreCategoria = reader.GetString(1),
                Descripcion = reader.GetString(2),
                RowVersion = (byte[])reader[3]
                
            };
        }

        public int Agregar(Categoria categoria)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "INSERT INTO Categorias (NombreCategoria, Descripcion) VALUES (@nom, @desc)";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@desc", categoria.Descripcion);

                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT @@IDENTITY";
                        comando = new SqlCommand(cadenaComando, cn);
                        categoria.CategoriaId = (int)(decimal)comando.ExecuteScalar();
                        cadenaComando = "SELECT RowVersion FROM Categorias WHERE CategoriaId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                        categoria.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_"))
                {
                    throw new Exception("Categoría repetida");
                }

                throw new Exception(e.Message);
            }
        }

        public int Borrar(Categoria categoria)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "DELETE FROM Categorias WHERE CategoriaId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                    comando.Parameters.AddWithValue("@r", categoria.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("REFERENCE"))
                {
                    throw new Exception("Registro relacionado... baja denegada");
                }
                throw new Exception(e.Message);
            }
        }

        public int Editar(Categoria categoria)
        {
            int registrosAfectados = 0;
            try
            {
                using (var cn = conexionBd.AbrirConexion())
                {
                    var cadenaComando = "UPDATE Categorias SET NombreCategoria=@nom, Descripcion=@desc WHERE CategoriaId=@id AND RowVersion=@r";
                    var comando = new SqlCommand(cadenaComando, cn);
                    comando.Parameters.AddWithValue("@nom", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@desc", categoria.Descripcion);
                    comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                    comando.Parameters.AddWithValue("@r", categoria.RowVersion);
                    registrosAfectados = comando.ExecuteNonQuery();
                    if (registrosAfectados > 0)
                    {
                        cadenaComando = "SELECT RowVersion FROM Categorias WHERE CategoriaId=@id";
                        comando = new SqlCommand(cadenaComando, cn);
                        comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                        categoria.RowVersion = (byte[])comando.ExecuteScalar();
                    }
                }

                return registrosAfectados;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("IX_"))
                {
                    throw new Exception("Categoría repetida");
                }
                throw new Exception(e.Message);
            }
        }

    }
}
