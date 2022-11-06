using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaAppComercial2022.Windows.Clases
{
    public class Carrito
    {
        private List<ItemCarrito> listaItems;
        public static Carrito instancia = null;

        public static Carrito GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new Carrito();
            }

            return instancia;
        }

        public Carrito()
        {
            listaItems = new List<ItemCarrito>();
        }

        public void Agregar(ItemCarrito item)
        {
            var itemEnCarrito = listaItems.SingleOrDefault(i => i.ProductoId == item.ProductoId);
            if (itemEnCarrito==null)
            {
                listaItems.Add(item);
                
            }
            else
            {
                itemEnCarrito.Cantidad++;
            }
        }

        public List<ItemCarrito> GetListaItems() => listaItems;
        public decimal GetTotal() => listaItems.Sum(i => i.Cantidad * i.Precio);
        public int GetCantidad() => listaItems.Sum(i => i.Cantidad);
    }
}
