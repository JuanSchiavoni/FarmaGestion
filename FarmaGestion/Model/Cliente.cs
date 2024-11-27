namespace FarmaGestion.Model
{
    public class Cliente
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public long DNI { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public long NumeroTelefono { get; set; } = 0;
        public string ObraSocial { get; set; } = string.Empty;
        public List<Producto> ProductosList { get; set; } = new();
        public int Descuento1 { get; set; } = 0;
        public int Descuento2 { get; set; } = 0;
        public int Descuento3 { get; set; } = 0;
        public int Descuento4 { get; set; } = 0;
        public string TipoDescuento { get; set; } = string.Empty;

    }
}
