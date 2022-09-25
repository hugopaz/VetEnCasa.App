using System;
using System.Collections.Generic;

namespace VetEnCasa.App.Dominio
{
    public class Cliente : Persona
    {
        public string direccion {get; set;}
        public List<Mascota> Mascotas {get; set;}
    }
}