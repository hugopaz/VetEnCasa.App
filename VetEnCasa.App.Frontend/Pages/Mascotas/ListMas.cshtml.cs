using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetEnCasa.App.Dominio;
using VetEnCasa.App.Persistencia;
using Microsoft.AspNetCore.Authorization;

namespace VetEnCasa.App.Frontend.Pages
{
    public class ListMasModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        private readonly IRepositorioCliente repositorioCliente;

        public IEnumerable<Cliente> Clientes {set;get;}
        public IEnumerable<Mascota> Mascotas {set;get;}


        public ListMasModel()
        {
            this.repositorioMascota = new RepositorioMascota(new VetEnCasa.App.Persistencia.AppContext());
            this.repositorioCliente = new RepositorioCliente(new VetEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            Clientes = repositorioCliente.GetAllClientes();
            Mascotas = repositorioMascota.GetAllMascota();
        }

        public void OnPost(int idMascota)
        {
            repositorioMascota.DeleteMascota(idMascota);
            Clientes = repositorioCliente.GetAllClientes();
        }
    }
}
