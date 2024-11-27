using FarmaGestion.Model;

namespace FarmaGestion.Components.Pages.ProductoFold
{
    public partial class ProductoPage
    {
        private bool modificando = false;

        private string Error = "";
        private Producto productoModif;

        private long Codigo = 0;
        private string Nombre = "";
        private string Tipo = "";
        private decimal Precio = 0;

        private List<Producto> ProductosList = new();

        private ProductoModal modal = default;

        private void NuevoProducto()
        {
            productoModif = new Producto();
            modal.Open();
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
                    ProductosList.Add(productoModif);
                }
                else 
                {
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
            ProductosList.Remove(producto);
        }
    }
}
