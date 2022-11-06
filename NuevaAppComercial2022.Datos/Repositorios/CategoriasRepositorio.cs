using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Datos.Repositorios
{
    public class CategoriasRepositorio
    {
        private SqlConnection cn;

        public CategoriasRepositorio(SqlConnection cn)
        {
            this.cn = cn;
        }

        public List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();
            try
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

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Borrar(Categoria categoria)
        {
            int registrosAfectados = 0;
            try
            {
                var cadenaComando = "DELETE FROM Categorias WHERE CategoriaId=@id AND RowVersion=@r";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", categoria.CategoriaId);
                comando.Parameters.AddWithValue("@r", categoria.RowVersion);
                registrosAfectados = comando.ExecuteNonQuery();

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Editar(Categoria categoria)
        {
            int registrosAfectados = 0;
            try
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

                return registrosAfectados;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Categoria GetCategoriaPorId(int id)
        {
            Categoria categoria = null;
            try
            {
                var cadenaComando = "SELECT CategoriaId, NombreCategoria, Descripcion, RowVersion FROM Categorias WHERE CategoriaId=@id";
                var comando = new SqlCommand(cadenaComando, cn);
                comando.Parameters.AddWithValue("@id", id);
                using (var reader = comando.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        categoria = ConstruirCategoria(reader);
                    }
                }

                return categoria;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
