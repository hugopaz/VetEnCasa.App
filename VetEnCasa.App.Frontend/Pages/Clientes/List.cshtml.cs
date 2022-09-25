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
    public class ListModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;
        public IEnumerable<Cliente> Clientes {set;get;}
        public ListModel()
        {
            this.repositorioClientes=new RepositorioCliente(new VetEnCasa.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            Clientes = repositorioClientes.GetAllClientes();
        }
    }
}

//@ class="fa-solid fa-arrow-right-from-bracket" *@
