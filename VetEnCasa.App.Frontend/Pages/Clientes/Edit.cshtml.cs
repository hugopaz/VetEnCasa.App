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
    public class EditModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;
        [BindProperty]

        public Cliente Cliente{set;get;}

        public EditModel()
        {
            this.repositorioClientes=new RepositorioCliente(new VetEnCasa.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? clienteId)
        {
            if (clienteId.HasValue)
            {
                Cliente = repositorioClientes.GetCliente(clienteId.Value);
            }
            else
            {
                Cliente= new Cliente();
            }
            if (Cliente == null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
                if (!ModelState.IsValid)
                {
                    return Page();
                }
                if (Cliente.Id>0)
                {
                    
                    Cliente= repositorioClientes.UpdateCliente(Cliente);
                }
                else
                {
                    repositorioClientes.AddCliente(Cliente);
                }
                return Page();
        }
        
    }
}