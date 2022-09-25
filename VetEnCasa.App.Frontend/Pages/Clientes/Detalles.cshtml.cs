using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetEnCasa.App.Dominio;
using VetEnCasa.App.Persistencia;

namespace VetEnCasa.App.Frontend.Pages
{
    public class DetallesModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;
        public Cliente Cliente {set; get;}
        public DetallesModel()
        {
            this.repositorioClientes=new RepositorioCliente(new VetEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int Id)
        {
            Cliente = repositorioClientes.GetCliente(Id);
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
