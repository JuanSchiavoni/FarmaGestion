﻿namespace FarmaGestion.Model
{
    public class Producto
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public long Codigo { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public decimal Precio { get; set; } = 0;
    }
}
