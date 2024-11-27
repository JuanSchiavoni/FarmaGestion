using FarmaGestion.Components.Pages.ClienteFold;
using FarmaGestion.Data;
using FarmaGestion.Model;
using Microsoft.AspNetCore.Components;

namespace FarmaGestion.Components.Pages.ProductoFold
{
    public partial class ProductoPage
    {
        [Inject]
        private FarmaGestionContext context {  get; set; }

        private bool modificando = false;

        private string Error = "";
        private Producto productoModif;

        private long Codigo = 0;
        private string Nombre = "";
        private string Tipo = "";
        private decimal Precio = 0;

        private List<Producto>? ProductosList;

        private ProductoModal modal = default;

        private void NuevoProducto()
        {
            productoModif = new Producto();
            modal.Open();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GetData();
        }

        private void GetData()
        {
            ProductosList = context.Productos.ToList();
        }

        private void Guardar()
        {
            if (productoModif.Codigo == 0 || productoModif.Nombre == "" || productoModif.Tipo == "" || productoModif.Precio == 0)
            {
                Error = "No se ingresaron todos los datos Necesarios";
            }
            else
            {
                if (!modificando)
                {
                    context.Productos.Add(productoModif);
                    context.SaveChanges();
                    GetData();
                }
                else 
                {
                    context.Entry(productoModif).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    GetData();
                    modificando = false;
                }

                productoModif = null;
                Error = "";
                modal.Close();
            }
        }

        private void Modificar(Producto prodMod)
        {
            modificando = true;
            productoModif = prodMod;
            modal.Open();
        }

        private void Eliminar(Producto producto)
        {
            context.Productos.Remove(producto);
            context.SaveChanges();
            GetData();
        }
    }
}
