using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioOficina
    {
        IEnumerable<Oficina> GetAllOficinas();
        Oficina GetOficina(int idOficina);
        Oficina AddOficina(Oficina oficina);
        Oficina UpdateOficina(Oficina oficina);
        void DeleteOficina(int idOficina);

    }
}