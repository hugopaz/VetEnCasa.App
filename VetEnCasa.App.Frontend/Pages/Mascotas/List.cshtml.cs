using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VetEnCasa.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioCliente repositorioCliente;

        public IEnumerable<Cliente> Clientes {set;get;}

        public ListModel()
        {
            this.repositorioMascota = new RepositorioMascota(new VetEnCasa.App.Persistencia.AppContext());
            this.repositorioCliente = new RepositorioCliente(new VetEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Clientes = repositorioClientes.GetAllClientes();
        }

        public void OnPost(int idMascota)
        {
            repositorioMascota.DeleteMascotas(idMascota);
            viewData["Respuesta"] = Alerts.ShowAlert(Alert.Danger, "<span>La mascota se va a eliminar</>");
            Cliente = repositorioCliente.GetAllClientes();
        }
    }
}
