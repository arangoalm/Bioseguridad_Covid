using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private readonly AppContext _appContext;
        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonalAseo()
        {
            return _appContext.personalAseo;
        }

        PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.personalAseo.FirstOrDefault(p => p.id ==idPersonalAseo);
            return personalAseoEncontrado;
        }
//ADD
        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoAdicionado = _appContext.personalAseo.Add(personalAseo);
            _appContext.SaveChange();
            return personalAseoAdicionado.EntityFrameworkCore;
        }
//Update
        PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoEncontrado = _appContext.personalAseo.FirstOrDefault(p => p.id==idPersonalAseo);
            if(personalAseoEncontrado != null)
            {
                personalAseoEncontrado.nombre = personalAseo.nombre;
                personalAseoEncontrado.apellidos = personalAseo.apellidos;
                personalAseoEncontrado.identificacion = personalAseo.identificacion;
                personalAseoEncontrado.edad = personalAseo.edad;
                personalAseoEncontrado.profesion = personalAseo.profesion;
                personalAseoEncontrado.turnoDesarrolloServicio = personalAseo.turnoDesarrolloServicio;

                _appContext.SaveChange();
 
            }
            return personalAseoEncontrado;
        }
//Delelte        
        void IRepositorioPersonalAseo.DeletePersonalAseo(int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.personalAseo.FirstOrDefault(p => p.id==idPersonalAseo);
            if (personalAseoEncontrado == null)
                return;
            _appContext.personalAseo.Remove(personalAseoEncontrado);
            _appContext.SaveChange();
        }
    }
}