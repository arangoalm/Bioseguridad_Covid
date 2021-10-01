using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioOficina : IRepositorioOficina
    {
        private readonly AppContext _appContext
        public RepositorioOficina(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<Oficina> IRepositorioOficina.GetAllOficinas()
        {
            return _appContext.oficinas;
        }

        Oficina IRepositorioOficina.GetOficina(int idOficina)
        {
            var oficinaEncontrado = _appContext.oficinas.FirstOrDefault(p => o.id ==idOficina);
            return oficinaEncontrado;
        }
//ADD
        Oficina IRepositorioOficina.AddOficina(Oficina oficina)
        {
            var oficinaAdicionado = _appContext.oficinas.Add(oficina);
            _appContext.SaveChange();
            return oficinaAdicionado.EntityFrameworkCore;
        }
//Update
        Oficina IRepositorioOficina.UpdateOficina(Oficina oficina)
        {
            var oficinaEncontrado = _appContext.oficinas.FirstOrDefault(o => o.id==idOficina);
            if(oficinaEncontrado != null)
            {
                oficinaEncontrado.aforoHora = oficina.aforoHora;
                oficinaEncontrado.disponibilidad = oficina.disponibilidad;
                

                _appContext.SaveChange();
 
            }
            return oficinaEncontrado;
        }
//Delelte        
        void IRepositorioOficina.DeleteOficina(int idOficina)
        {
            var oficinaEncontrado = _appContext.oficinas.FirstOrDefault(o=>o.id==idOficina);
            if (oficinaEncontrado == null)
                return;
            _appContext.oficinas.Remove(oficinaEncontrado);
            _appContext.SaveChange();
        }
    }
}