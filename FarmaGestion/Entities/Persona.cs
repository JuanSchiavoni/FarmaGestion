namespace FarmaGestion.Entities
{
    public abstract class Persona
    {
        public long DNI = 0;
        public string Nombre = "";
        public string Apellido = "";
        public string Direccion = "";

        public Persona() { }

        public Persona (long dni, string nombre, string apellido, string direccion)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
        }
    }
}
