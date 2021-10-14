using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioSecretarioDespacho : IRepositorioSecretarioDespacho
    {
        private readonly AppContext _appContext;
        public RepositorioSecretarioDespacho(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<SecretarioDespacho> IRepositorioSecretarioDespacho.GetAllSecretarioDespachos()
        {
            return _appContext.secretarioDespacho;
        }

        SecretarioDespacho IRepositorioSecretarioDespacho.GetSecretarioDespacho(int idSecretarioDespacho)
        {
            var secretarioDespachoEncontrado = _appContext.secretarioDespacho.FirstOrDefault(p => p.id ==idSecretarioDespacho);
            return secretarioDespachoEncontrado;
        }
//ADD
        SecretarioDespacho IRepositorioSecretarioDespacho.AddSecretarioDespacho(SecretarioDespacho secretarioDespacho)
        {
            var secretarioDespachoAdicionado = _appContext.secretarioDespacho.Add(secretarioDespacho);
            _appContext.SaveChange();
            return secretarioDespachoAdicionado.EntityFrameworkCore;
        }
//Update
        SecretarioDespacho IRepositorioSecretarioDespacho.UpdateSecretarioDespacho(SecretarioDespacho secretarioDespacho)
        {
            var secretarioDespachoEncontrado = _appContext.secretarioDespacho.FirstOrDefault(p => p.id==idSecretarioDespacho);
            if(secretarioDespachoEncontrado != null)
            {
                secretarioDespachoEncontrado.nombre = secretarioDespacho.nombre;
                secretarioDespachoEncontrado.apellidos = secretarioDespacho.apellidos;
                secretarioDespachoEncontrado.identificacion = secretarioDespacho.identificacion;
                secretarioDespachoEncontrado.edad = secretarioDespacho.edad;
                secretarioDespachoEncontrado.profesion = secretarioDespacho.profesion;
                secretarioDespachoEncontrado.despacho = secretarioDespacho.despacho;

                _appContext.SaveChange();
 
            }
            return secretarioDespachoEncontrado;
        }
//Delelte        
        void IRepositorioSecretarioDespacho.DeleteSecretarioDespacho(int idSecretarioDespacho)
        {
            var secretarioDespachoEncontrado = _appContext.secretarioDespacho.FirstOrDefault(p=>p.id==idSecretarioDespacho);
            if (secretarioDespachoEncontrado == null)
                return false;
            _appContext.secretarioDespacho.Remove(secretarioDespachoEncontrado);
            _appContext.SaveChange();
            return true;
        }
    }
}