using System;
using System.Collections.Generic;
using System.Linq;
using VetEnCasa.App.Dominio;

namespace VetEnCasa.App.Persistencia
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAllMascota();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int idMascota);
        Mascota GetMascota(int idMascota);
    }
}