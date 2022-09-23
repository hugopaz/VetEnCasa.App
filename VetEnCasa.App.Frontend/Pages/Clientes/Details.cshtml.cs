using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetEnCasa.App.Dominio;
using VetEnCasa.App.Persistencia;
//using Microsoft.AspNetCore.Authorization;

namespace VetEnCasa.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;

        public Cliente Cliente {set;get;}
        public DetailsModel()
        {
            this.repositorioClientes=new repositorioClientes(new VetEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int clienteId)
        {
            Cliente = repositorioClientes.GetCliente(clienteId);
            if(Cliente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

    }
}
