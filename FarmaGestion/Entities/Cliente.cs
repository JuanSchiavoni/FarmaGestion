namespace FarmaGestion.Entities
{
    public class Cliente : Persona
    {
        public long NumeroTelefono;
        public string ObraSocial = "";
        public List<Producto>? productos;

        public Cliente() : base() {}

        public Cliente(long dni, string nombre, string apellido, string direccion, long numTel, string obraSoc) : base(dni, nombre, apellido, direccion)
        {
            NumeroTelefono = numTel;
            ObraSocial = obraSoc;
        }
    }
}
