﻿namespace NuevaAppComercial2022.Windows.Class
{
    public class ItemCarrito
    {
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal => Precio * Cantidad;
    }
}
