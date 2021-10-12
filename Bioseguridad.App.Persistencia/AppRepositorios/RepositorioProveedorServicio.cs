using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioProveedorServicio : IRepositorioProveedorServicio
    {
        private readonly AppContext _appContext;
        public RepositorioProveedorServicio(AppContext appContext)
        {
            _appContext = appContext;
        }
//CRUD
//GET
        IEnumerable<ProveedorServicio> IRepositorioProveedorServicio.GetAllProveedorServicios()
        {
            return _appContext.proveedorServicios;
        }

        ProveedorServicio IRepositorioProveedorServicio.GetProveedorServicio(int idProveedorServicio)
        {
            var proveedorServicioEncontrado = _appContext.proveedorServicios.FirstOrDefault(p => p.id ==idProveedorServicio);
            return proveedorServicioEncontrado;
        }
//ADD
        ProveedorServicio IRepositorioProveedorServicio.AddProveedorServicio(ProveedorServicio ProveedorServicio)
        {
            var proveedorServicioAdicionado = _appContext.proveedorServicios.Add(ProveedorServicio);
            _appContext.SaveChange();
            return proveedorServicioAdicionado.EntityFrameworkCore;
        }
//Update
        ProveedorServicio IRepositorioProveedorServicio.UpdateProveedorServicio(ProveedorServicio proveedorServicio)
        {
            var proveedorServicioEncontrado = _appContext.proveedorServicios.FirstOrDefault(p => p.id==idProveedorServicio);
            if(proveedorServicioEncontrado != null)
            {
                proveedorServicio.nombre = proveedorServicio.nombre;
                proveedorServicio.apellidos = proveedorServicio.apellidos;
                proveedorServicio.identificacion = proveedorServicio.identificacion;
                proveedorServicio.edad = proveedorServicio.edad;
                proveedorServicio.profesion = proveedorServicio.profesion;
                proveedorServicio.servicioRealizado = proveedorServicio.servicioRealizado;
                proveedorServicio.unidadServicioRealizadoa = proveedorServicio.unidadServicioRealizadoo;

                _appContext.SaveChange();
 
            }
            return personaEncontrado;
        }
//Delelte        
        void IRepositorioProveedorServicio.DeleteProveedorServicio(int idProveedorServicio)
        {
            var proveedorServicioEncontrado = _appContext.proveedorServicios.FirstOrDefault(p => p.id==idProveedorServicio);
            if (personaEncontrado == null)
                return;
            _appContext.proveedorServicios.Remove(proveedorServiciosEncontrado);
            _appContext.SaveChange();
        }
    }
}