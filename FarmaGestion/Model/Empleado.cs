namespace FarmaGestion.Model
{
    public class Empleado
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public long DNI { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public long NumeroTelefono { get; set; } = 0;
    }
}
