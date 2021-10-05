using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioPersonalAseo : IRepositorioPersonalAseo
    {
        private readonly AppContext _appContext
        public RepositorioPersonalAseo(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<PersonalAseo> IRepositorioPersonalAseo.GetAllPersonalAseos()
        {
            return _appContext.personalAseos;
        }

        PersonalAseo IRepositorioPersonalAseo.GetPersonalAseo(int idPersonalAseo)
        {
            var personalAseoEncontrado = _appContext.personalAseos.FirstOrDefault(p => a.id ==idPersonalAseo);
            return personalAseoEncontrado;
        }
//ADD
        PersonalAseo IRepositorioPersonalAseo.AddPersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoAdicionado = _appContext.personalAseos.Add(personalAseo);
            _appContext.SaveChange();
            return personalAseoAdicionado.EntityFrameworkCore;
        }
//Update
        PersonalAseo IRepositorioPersonalAseo.UpdatePersonalAseo(PersonalAseo personalAseo)
        {
            var personalAseoEncontrado = _appContext.personalAseos.FirstOrDefault(a => a.id==idPersonalAseo);
            if(personalAseoEncontrado != null)
            {
                personaAseoEncontrado.nombre = personalAseo.nombre;
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
            var personalAseoEncontrado = _appContext.personalAseos.FirstOrDefault(a=>a.id==idPersonalAseo);
            if (personalAseoEncontrado == null)
                return;
            _appContext.personalAseos.Remove(personalAseoEncontrado);
            _appContext.SaveChange();
        }
    }
}