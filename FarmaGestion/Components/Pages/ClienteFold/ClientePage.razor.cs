using FarmaGestion.Entities;


namespace FarmaGestion.Components.Pages.ClienteFold
{
    public partial class ClientePage
    {
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

        private List<Cliente> ClientesList = new();

        private ClienteModal modal = default;

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
                    ClientesList.Add(clienteMod);
                }
                else
                {
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
            ClientesList.Remove(clienteEliminar);
        }
    }
}

