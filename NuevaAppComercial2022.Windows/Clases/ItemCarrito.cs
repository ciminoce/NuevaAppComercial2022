using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevaAppComercial2022.Windows.Clases
{
    public class ItemCarrito
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public decimal Subtotal => Precio * Cantidad;

        public override bool Equals(object obj)
        {
            if (obj==null ||!(obj is ItemCarrito))
            {
                return false;
            }

            return this.NombreProducto == ((ItemCarrito) obj).NombreProducto;
        }
        
    }
}
