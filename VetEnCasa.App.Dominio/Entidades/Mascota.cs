using System;
using System.Collections.Generic;

namespace VetEnCasa.App.Dominio

{
    public class Mascota
    {
        public string nombre {get;set;}
        public string raza {get; set;}
        public string tipo {get; set;}
        public Cliente Cliente{get; set;}
    }
}