namespace FarmaGestion.Entities
{
    public class Cliente : Persona
    {
        public long NumeroTelefono;
        public string ObraSocial = "";
        public List<Producto>? productos;
        public int Descuento1 = 0;
        public int Descuento2 = 0;
        public int Descuento3 = 0;
        public int Descuento4 = 0;
        public string TipoDescuento = "";


        public Cliente() : base() {}

        public Cliente(long dni, string nombre, string apellido, string direccion, long numTel, string obraSoc, int descuento1, int descuento2, int descuento3, int descuento4, string tipodesc) : base(dni, nombre, apellido, direccion)
        {
            NumeroTelefono = numTel;
            ObraSocial = obraSoc;
            Descuento1 = descuento1;
            Descuento2 = descuento2;
            Descuento3 = descuento3;
            Descuento4 = descuento4;
            TipoDescuento= tipodesc;
        }
    }
}
