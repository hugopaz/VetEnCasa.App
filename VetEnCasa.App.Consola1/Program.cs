using System;
using VetEnCasa.App.Dominio;
using VetEnCasa.App.Persistencia;

namespace VetEnCasa.App.Consola1
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! vamosss");
            //AddCliente();
            BuscarCliente(1);
        }

        private static void AddCliente()
        {
            var cliente = new Cliente()
            {
                Nombres = "12345",
                Apellidos = "Perez",
                Telefono = "324245",
                direccion = "Santa Marta"
            };
            _repoCliente.AddCliente(cliente);
        }
        private static void BuscarCliente(int idCliente)
        {
            var cliente = _repoCliente.GetCliente(idCliente);
            Console.WriteLine(cliente.Nombres);
        }
    }
}
