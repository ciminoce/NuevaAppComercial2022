using System;

namespace NuevaAppComercial2022.Entidades.Entidades
{
    public class Ciudad:ICloneable
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }
        public int PaisId { get; set; }
        public byte[] RowVersion { get; set; }
        public Pais Pais { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
