using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioGobernador : IRepositorioGobernador
    {
        private readonly AppContext _appContext
        public RepositorioGobernador(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<Gobernador> IRepositorioGobernador.GetAllGobernadores()
        {
            return _appContext.gobernadores;
        }

        Gobernador IRepositorioGobernador.GetGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(p => g.id ==idGobernador);
            return gobernadorEncontrado;
        }
//ADD
        Gobernador IRepositorioGobernador.AddGobernador(Gobernador gobernador)
        {
            var gobernadorAdicionado = _appContext.gobernadores.Add(gobernador);
            _appContext.SaveChange();
            return gobernadorAdicionado.EntityFrameworkCore;
        }
//Update
        Gobernador IRepositorioGobernador.UpdateGobernador(Gobernador gobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(g => g.id==idGobernador);
            if(gobernadorEncontrado != null)
            {
                gobernadorEncontrado.nombre = gobernador.nombre;
                gobernadorEncontrado.apellidos = gobernador.apellidos;
                gobernadorEncontrado.identificacion = gobernador.identificacion;
                gobernadorEncontrado.edad = gobernador.edad;
                gobernadorEncontrado.profesion = gobernador.profesion;
                gobernadorEncontrado.oficinaVisitada = gobernador.oficinaVisitada;

                _appContext.SaveChange();
 
            }
            return gobernadorEncontrado;
        }
//Delelte        
        void IRepositorioGobernador.DeleteGobernador(int idGobernador)
        {
            var gobernadorEncontrado = _appContext.gobernadores.FirstOrDefault(g=>g.id==idGobernador);
            if (gobernadorEncontrado == null)
                return;
            _appContext.gobernadores.Remove(gobernadorEncontrado);
            _appContext.SaveChange();
        }
    }
}