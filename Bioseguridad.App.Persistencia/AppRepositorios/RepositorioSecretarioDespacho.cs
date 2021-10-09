using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioSecretarioDespacho : IRepositorioSecretarioDespacho
    {
        private readonly AppContext _appContext
        public SecretarioDespacho(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<SecretarioDespacho> IRepositorioSecretarioDespacho.GetAllSecretarioDespachos()
        {
            return _appContext.secretarioDespachos;
        }

        SecretarioDespacho IRepositorioSecretarioDespacho.GetAllSecretarioDespachos(int idSecretarioDespachos)
        {
            var secretarioDespachoEncontrado = _appContext.secretarioDespachos.FirstOrDefault(p => s.id ==idSecretarioDespachos);
            return secretarioDespachoEncontrado;
        }
//ADD
        RegistroIngreso ISecretarioDespachoIngreso.AddSecretarioDespacho(SecretarioDespacho secretarioDespachos)
        {
            var secretarioDespachoAdicionado = _appContext.secretarioDespachos.Add(secretarioDespachos);
            _appContext.SaveChange();
            return personaAdicionado.EntityFrameworkCore;
        }
//Update
        RegistroIngreso ISecretarioDespachoIngreso.UpdateRegistroIngreso(RegistroIngreso persona)
        {
            var personaEncontrado = _appContext.personaes.FirstOrDefault(a => a.id==idRegistroIngreso);
            if(personaEncontrado != null)
            {
                personaEncontrado.nombre = persona.nombre;
                personaEncontrado.apellidos = persona.apellidos;
                personaEncontrado.identificacion = persona.identificacion;
                personaEncontrado.edad = persona.edad;
                personaEncontrado.profesion = persona.profesion;
                personaEncontrado.oficinaVisitada = persona.oficinaVisitada;

                _appContext.SaveChange();
 
            }
            return personaEncontrado;
        }
//Delelte        
        void ISecretarioDespachoIngreso.DeleteRegistroIngreso(int idRegistroIngreso)
        {
            var personaEncontrado = _appContext.personaes.FirstOrDefault(a=>a.id==idRegistroIngreso);
            if (personaEncontrado == null)
                return;
            _appContext.personaes.Remove(personaEncontrado);
            _appContext.SaveChange();
        }
    }
}