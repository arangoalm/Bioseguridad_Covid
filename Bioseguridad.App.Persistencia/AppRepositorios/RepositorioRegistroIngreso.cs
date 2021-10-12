using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioRegistroIngreso : IRepositorioRegistroIngreso
    {
        private readonly AppContext _appContext;
        public RepositorioRegistroIngreso(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<RegistroIngreso> IRepositorioRegistroIngreso.GetAllRegistroIngresos()
        {
            return _appContext.registroIngreso;
        }

        RegistroIngreso IRepositorioRegistroIngreso.GetRegistroIngreso(int idRegistroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngreso.FirstOrDefault(p => p.id ==idRegistroIngreso);
            return registroIngresoEncontrado;
        }
//ADD
        RegistroIngreso IRepositorioRegistroIngreso.AddRegistroIngreso(RegistroIngreso registroIngreso)
        {
            var registroIngresoAdicionado = _appContext.registroIngreso.Add(registroIngreso);
            _appContext.SaveChange();
            return registroIngresoAdicionado.EntityFrameworkCore;
        }
//Update
        RegistroIngreso IRepositorioRegistroIngreso.UpdateRegistroIngreso(RegistroIngreso registroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngreso.FirstOrDefault(p => p.id==idRegistroIngreso);
            if(registroIngresoEncontrado != null)
            {
                registroIngresoEncontrado.fechaIngreso = registroIngreso.fechaIngreso;
                registroIngresoEncontrado.horaIngreso = registroIngreso.horaIngreso;


                _appContext.SaveChange();
 
            }
            return registroIngresoEncontrado;
        }
//Delelte        
        void IRepositorioRegistroIngreso.DeleteRegistroIngreso(int idRegistroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngreso.FirstOrDefault(p => p.id==idRegistroIngreso);
            if (registroIngresoEncontrado == null)
                return;
            _appContext.registroIngreso.Remove(registroIngresoEncontrado);
            _appContext.SaveChange();
        }
    }
}