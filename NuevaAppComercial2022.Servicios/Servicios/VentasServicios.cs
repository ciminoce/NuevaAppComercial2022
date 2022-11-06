using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevaAppComercial2022.Datos;
using NuevaAppComercial2022.Datos.Repositorios;
using NuevaAppComercial2022.Entidades.Entidades;
using NuevaAppComercial2022.Entidades.Enums;

namespace NuevaAppComercial2022.Servicios.Servicios
{
    public class VentasServicios
    {
        private VentasRepositorio repositorio;
        private ClientesRepositorio repoCliente;
        private DetalleVentasRepositorio repoDetalle;
        private ProductosRepositorio repoProducto;
        private CtasCteRepositorio repoCtaCte;
        private readonly SqlConnection cn;

        public VentasServicios()
        {
            
        }

        public List<Venta> GetLista()
        {
            List<Venta> lista;
            try
            {
                using (var cn=ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new VentasRepositorio(cn);
                    repoCliente = new ClientesRepositorio(cn);
                    lista = repositorio.GetLista();
                    foreach (var venta in lista)
                    {
                        venta.Cliente = repoCliente.GetClientePorId(venta.ClienteId);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<DetalleVenta> GetDetalleVenta(int id)
        {
            List<DetalleVenta> detalle = new List<DetalleVenta>();
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repoDetalle = new DetalleVentasRepositorio(cn);
                    repoProducto = new ProductosRepositorio(cn);
                    detalle = repoDetalle.GetDetalleVentas(id);
                    foreach (var detalleVta in detalle)
                    {
                        detalleVta.Producto = repoProducto.GetProductoPorId(detalleVta.ProductoId);
                    }
                }

                return detalle;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public void Guardar(Venta venta)
        {
            SqlTransaction tran = null;
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    tran = cn.BeginTransaction();
                    repositorio = new VentasRepositorio(cn, tran);
                    repoDetalle = new DetalleVentasRepositorio(cn, tran);
                    repoProducto = new ProductosRepositorio(cn, tran);
                    repoCtaCte = new CtasCteRepositorio(cn, tran);

                    repositorio.Guardar(venta);
                    foreach (var ventaDetalle in venta.Detalles)
                    {
                        ventaDetalle.VentaId = venta.VentaId;
                        repoDetalle.Guardar(ventaDetalle);
                        repoProducto.ActualizarStock(ventaDetalle.ProductoId, ventaDetalle.Cantidad);
                        repoProducto.ActualizarUnidadesEnPedido(ventaDetalle.ProductoId,-ventaDetalle.Cantidad);
                    }
                    var saldo = repoCtaCte.GetSaldo(venta.ClienteId, cn, tran);//consulto el saldo del cliente
                    //Creo la clase ctacte y le paso los datos
                    var ctaCte = new CtaCte
                    {
                        FechaMovimiento = venta.FechaVenta,
                        ClienteId = venta.ClienteId,
                        Debe = venta.Total,
                        Haber = 0,
                        Saldo = saldo + venta.Total,
                        Movimiento = $"FACT {venta.VentaId}"

                    };
                    repoCtaCte.Agregar(ctaCte, cn, tran);//Agrego el registro en la tabla de CtasCtes

                    tran.Commit();
                }


            }
            catch (Exception e)
            {
                tran.Rollback();
            }

        }

        public List<Venta> GetLista(DateTime fechaBuscar)
        {
            List<Venta> lista;
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new VentasRepositorio(cn);
                    repoCliente = new ClientesRepositorio(cn);
                    lista = repositorio.GetLista(fechaBuscar);
                    foreach (var venta in lista)
                    {
                        venta.Cliente = repoCliente.GetClientePorId(venta.ClienteId);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<Venta> GetLista(Cliente cliente)
        {
            List<Venta> lista;
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    repositorio = new VentasRepositorio(cn);
                    repoCliente = new ClientesRepositorio(cn);
                    lista = repositorio.GetLista(cliente);
                    foreach (var venta in lista)
                    {
                        venta.Cliente = repoCliente.GetClientePorId(venta.ClienteId);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Pagar(Venta venta, FormaPago forma, decimal importe)
        {
            SqlTransaction tran = null;
            try
            {
                using (var cn = ConexionBd.GetInstancia().AbrirConexion())
                {
                    tran = cn.BeginTransaction();
                    repositorio = new VentasRepositorio(cn, tran);
                    repoCtaCte = new CtasCteRepositorio(cn, tran);
                    venta.Estado = Estado.Paga;
                    repositorio.Editar(venta);
                    var saldo = repoCtaCte.GetSaldo(venta.ClienteId, cn, tran);//consulto el saldo del cliente
                    
                    //Creo la clase ctacte y le paso los datos
                    var ctaCte = new CtaCte
                    {
                        FechaMovimiento =DateTime.Now,
                        ClienteId = venta.ClienteId,
                        Debe = 0,
                        Haber = importe,
                        Saldo = saldo - importe,
                        Movimiento = ConstruirMovimiento(venta,forma)

                    };
                    repoCtaCte.Agregar(ctaCte, cn, tran);//Agrego el registro en la tabla de CtasCtes

                    tran.Commit();
                }


            }
            catch (Exception e)
            {
                tran.Rollback();
            }

        }

        private string ConstruirMovimiento(Venta venta, FormaPago forma)
        {
            return $"PAGO {forma.ToString()} {venta.VentaId}";

        }
    }
}
