using Bioseguridad.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Bioseguridad.App.Persistencia
{
    public class RepositorioAsesor : IRepositorioAsesor
    {
        private readonly AppContext _appContext
        public RepositorioAsesor(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Asesor> IRepositorioAsesor.GetAllAsesores()
        {
            return _appContext.asesores;
        }

        Asesor IRepositorioAsesor.GetAsesor(int idAsesor)
        {
            var asesorEncontrado = _appContext.asesores.FirstOrDefault(p => a.id ==idAsesor);
            return asesorEncontrado;
        }

        Asesor IRepositorioAsesor.AddAsesor(Asesor asesor)
        {
            var asesorAdicionado = _appContext.asesores.Add(asesor);
            _appContext.SaveChange();
            return asesorAdicionado.EntityFrameworkCore;
        }

        Asesor IRepositorioAsesor.UpdateAsesor(Asesor asesor)
        {
            var asesorEncontrado = _appContext.asesores.FirstOrDefault(a => a.id==idAsesor);
            if(asesorEncontrado != null)
            {
                asesorEncontrado.nombre = asesor.nombre;
                asesorEncontrado.apellidos = asesor.apellidos;
                asesorEncontrado.identificacion = asesor.identificacion;
                asesorEncontrado.edad = asesor.edad;
                asesorEncontrado.profesion = asesor.profesion;
                asesorEncontrado.oficinaVisitada = asesor.oficinaVisitada;

                _appContext.SaveChange();
 
            }
            return asesorEncontrado;
        }
        void IRepositorioAsesor.DeleteAsesor(int idAsesor)
        {
            var asesorEncontrado = _appContext.asesores.FirstOrDefault(a=>a.id==idAsesor);
            if (asesorEncontrado == null)
                return;
            _appContext.asesores.Remove(asesorEncontrado);
            _appContext.SaveChange();
        }
    }
}