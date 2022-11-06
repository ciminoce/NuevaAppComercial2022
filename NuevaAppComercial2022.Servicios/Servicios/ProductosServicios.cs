using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class ProductosServicios
    {
        private ProductosRepositorio repositorio;
        private CategoriasRepositorio repoCategorias;
        private ProveedoresRepositorio repoProveedores;

        public ProductosServicios()
        {
        }

        public List<Producto> GetLista(Categoria categoria=null)
        {
            try
            {
                List<Producto> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    repoCategorias = new CategoriasRepositorio(cn);
                    lista = repositorio.GetLista(categoria);
                    foreach (var producto in lista)
                    {
                        producto.Categoria = repoCategorias.GetCategoriaPorId(producto.CategoriaId);
                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void ActualizarUnidadesEnPedido(int productoId, int cantidad)
        {
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    repositorio.ActualizarUnidadesEnPedido(productoId, cantidad);
                }

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public bool Existe(Producto producto)
        {
            try
            {
                bool existe = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);

                    existe = repositorio.Existe(producto);
                }

                return existe;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int Agregar(Producto producto)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);

                    registros = repositorio.Agregar(producto);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public bool EstaRelacionado(Producto producto)
        {
            try
            {
                bool estaRelacionado = true;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    estaRelacionado = repositorio.EstaRelacionado(producto);
                }

                return estaRelacionado;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }

        public int Borrar(Producto producto)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);

                    registros = repositorio.Borrar(producto);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public int Editar(Producto producto)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);

                    registros = repositorio.Editar(producto);
                }

                return registros;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public List<Producto> GetListaPaginada(int paginaActual, int registrosPorPagina, Categoria categoria=null)
        {
            try
            {
                List<Producto> lista = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    repoCategorias = new CategoriasRepositorio(cn);
                    lista = repositorio.GetListaPaginada(paginaActual,registrosPorPagina,categoria);
                    foreach (var producto in lista)
                    {
                        producto.Categoria = repoCategorias.GetCategoriaPorId(producto.CategoriaId);
                    }

                    return lista;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetCantidad(Categoria categoria = null)
        {
            try
            {
                int registros = 0;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    registros = repositorio.GetCantidad(categoria);
                }

                return registros;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Producto GetProductoPorId(int id)
        {
            try
            {
                Producto producto = null;
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new ProductosRepositorio(cn);
                    producto=repositorio.GetProductoPorId(id);
                }

                return producto;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
