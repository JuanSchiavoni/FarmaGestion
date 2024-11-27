using FarmaGestion.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FarmaGestion.Data
{
    public class FarmaGestionContext : IdentityDbContext<FarmaGestionUser>
    {
        public FarmaGestionContext(DbContextOptions<FarmaGestionContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }

}
