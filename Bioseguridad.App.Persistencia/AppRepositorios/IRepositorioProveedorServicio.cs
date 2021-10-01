using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioProveedorServicio
    {
        IEnumerable<ProveedorServicio> GetAllProveedorServicios();
        ProveedorServicio GetProveedorServicio(int idProveedorServicio);
        ProveedorServicio AddProveedorServicio(ProveedorServicio proveedorServicio);
        ProveedorServicio UpdateProveedorServicio(ProveedorServicio proveedorServicio);
        void DeleteProveedorServicio(int idProveedorServicio);

    }
}