using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            var personaEncontrado = _appContext.personas.FirstOrDefault(p => p.id ==idPersona);
            return personaEncontrado;
        }
//ADD
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.personas.Add(persona);
            _appContext.SaveChange();
            return personaAdicionado.EntityFrameworkCore;
        }
//Update
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado = _appContext.personas.FirstOrDefault(p => p.id==idPersona);
            if(personaEncontrado != null)
            {
                personaEncontrado.nombre = persona.nombre;
                personaEncontrado.apellidos = persona.apellidos;
                personaEncontrado.identificacion = persona.identificacion;
                personaEncontrado.edad = persona.edad;
                personaEncontrado.profesion = persona.profesion;
                

                _appContext.SaveChange();
 
            }
            return personaEncontrado;
        }
//Delelte        
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrado = _appContext.personas.FirstOrDefault(p => p.id==idPersona);
            if (personaEncontrado == null)
                return;
            _appContext.personas.Remove(personaEncontrado);
            _appContext.SaveChange();
        }
    }
}