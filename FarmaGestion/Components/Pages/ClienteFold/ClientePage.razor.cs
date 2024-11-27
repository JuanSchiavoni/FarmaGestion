using FarmaGestion.Data;
using FarmaGestion.Model;
using Microsoft.AspNetCore.Components;

namespace FarmaGestion.Components.Pages.ClienteFold
{
    public partial class ClientePage
    {
        [Inject]
        private FarmaGestionContext context {  get; set; }

        private bool modificando = false;

        private string Error = "";
        private Cliente clienteMod = new Cliente();
         
        private long dni = 0;
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private long numTel = 0;
        private string obraSoc = "";
        private int descuento1 = 0;
        private int descuento2 = 0;
        private int descuento3 = 0;
        private int descuento4 = 0;
        private string tipoDescuento = "";

        private List<Cliente>? ClientesList;

        private ClienteModal modal = default;

        protected override void OnInitialized()
        {
            base.OnInitialized();
            GetData();
        }

        private void GetData()
        {
            ClientesList = context.Clientes.ToList();
        }

        private void NuevoCliente()
        {
            clienteMod = new Cliente();
            modal.Open();
        }

        private void Guardar()
        {
            if (clienteMod.DNI == 0 || clienteMod.Nombre == "" || clienteMod.Apellido == "" || clienteMod.ObraSocial == "")
            {
                Error = "No se ingresaron todos los datos necesarios";
            }
            else
            {
                if (!modificando)
                {
                    context.Clientes.Add(clienteMod);
                    context.SaveChanges();

                    GetData();
                }
                else
                {
                    context.Entry(clienteMod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                    GetData();
                    modificando = false;
                }

                clienteMod = null;
                Error = "";
                modal.Close();
            }
        }

        private void Modificar(Cliente clienteModificar)
        {
            modificando = true;
            clienteMod = clienteModificar;
            modal.Open();
        }

        private void Eliminar(Cliente clienteEliminar)
        {
            context.Clientes.Remove(clienteEliminar);
            context.SaveChanges();
            GetData();
        }
    }
}

