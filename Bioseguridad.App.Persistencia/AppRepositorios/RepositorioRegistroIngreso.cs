using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioRegistroIngreso : IRepositorioRegistroIngreso
    {
        private readonly AppContext _appContext
        public RepositorioRegistroIngreso(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<RegistroIngreso> IRepositorioRegistroIngreso.GetAllRegistroIngresoes()
        {
            return _appContext.registroIngreso;
        }

        RegistroIngreso IRepositorioRegistroIngreso.GetRegistroIngreso(int idRegistroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngresos.FirstOrDefault(p => a.id ==idRegistroIngreso);
            return registroIngresoEncontrado;
        }
//ADD
        RegistroIngreso IRepositorioRegistroIngreso.AddRegistroIngreso(RegistroIngreso registroIngreso)
        {
            var registroIngresoAdicionado = _appContext.registroIngresos.Add(registroIngreso);
            _appContext.SaveChange();
            return registroIngresoAdicionado.EntityFrameworkCore;
        }
//Update
        RegistroIngreso IRepositorioRegistroIngreso.UpdateRegistroIngreso(RegistroIngreso registroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngresos.FirstOrDefault(a => a.id==idRegistroIngreso);
            if(personaEncontrado != null)
            {
                registroIngresoEncontrado.nombre = registroIngreso.nombre;
                registroIngresoEncontrado.apellidos = registroIngreso.apellidos;
                registroIngresoEncontrado.identificacion = registroIngreso.identificacion;
                registroIngresoEncontrado.edad = registroIngreso.edad;
                registroIngresoEncontrado.profesion = registroIngreso.profesion;
                registroIngresoEncontrado.fechaIngreso = registroIngreso.fechaIngreso;
                registroIngresoEncontrado.horaIngreso = persona.fechaIngreso;


                _appContext.SaveChange();
 
            }
            return registroIngresoEncontrado;
        }
//Delelte        
        void IRepositorioRegistroIngreso.DeleteRegistroIngreso(int idRegistroIngreso)
        {
            var registroIngresoEncontrado = _appContext.registroIngresos.FirstOrDefault(a=>a.id==idRegistroIngreso);
            if (registroIngresoEncontrado == null)
                return;
            _appContext.registroIngresos.Remove(registroIngresoEncontrado);
            _appContext.SaveChange();
        }
    }
}