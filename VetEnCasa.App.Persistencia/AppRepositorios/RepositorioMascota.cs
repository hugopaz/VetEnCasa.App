using System;
using System.Collections.Generic;
using System.Linq;
using VetEnCasa.App.Dominio;

namespace VetEnCasa.App.Persistencia

{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContext _appContext;

        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }
        Mascota IRepositorioMascota.AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }
        Mascota IRepositorioMascota.UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(c => c.Id == mascota.Id);
            if(mascotaEncontrado != null)
            {
                mascotaEncontrado.nombre = mascota.nombre;
                mascotaEncontrado.raza = mascota.raza;
                mascotaEncontrado.tipo = mascota.tipo;

                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }
        void IRepositorioMascota.DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(c => c.Id == idMascota);
            if (mascotaEncontrado == null)
            {
                return;
            }
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }
        Mascota IRepositorioMascota.GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(c => c.Id == idMascota);
        }

        IEnumerable<Mascota> IRepositorioMascota.GetAllMascota()
        {
            return _appContext.Mascotas;
        }
    }
}