using FarmaGestion.Components.Pages.ClienteFold;
using FarmaGestion.Entities;

namespace FarmaGestion.Components.Pages.Empleado
{
    public partial class EmpleadoPage
    {
        private bool modificando = false;

        private string Error = "";
        private Cliente? clienteMod;

        private long dni = 0;
        private string nombre = "";
        private string apellido = "";
        private string direccion = "";
        private long numTel = 0;
        private string obraSoc = "";

        private List<Cliente> ClientesList;

        private ClienteModal modal = new();

        private void NuevoCliente()
        {
            clienteMod = new Cliente();
            modal.Open();
        }

        private void Guardar()
        {
            if(clienteMod.DNI == 0 || clienteMod.Nombre == "" || clienteMod.Apellido == "" || clienteMod.ObraSocial == "")
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

        private void Eliminar(Cliente clienteEliminar)
        {
            ClientesList.Remove(clienteEliminar);
        }
    }
}
