using System;

namespace NuevaAppComercial2022.Entidades.Entidades
{
    public class Categoria:ICloneable
    {
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        public byte[] RowVersion { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
