using System;

namespace NuevaAppComercial2022.Entidades.Entidades
{
    public class Pais:ICloneable
    {
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
        public byte[] RowVersion { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
