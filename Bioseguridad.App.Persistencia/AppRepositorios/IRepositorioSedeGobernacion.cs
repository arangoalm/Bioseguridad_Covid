using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioSedeGobernacion
    {
        IEnumerable<SedeGobernacion> GetAllSedeGobernaciones();
        SedeGobernacion GetSedeGobernacion(int idSedeGobernacion);
        SedeGobernacion AddSedeGobernacion(SedeGobernacion sedeGobernacion);
        SedeGobernacion UpdateSedeGobernacion(SedeGobernacion sedeGobernacion);
        void DeleteSedeGobernacion(int idSedeGobernacion);

    }
}