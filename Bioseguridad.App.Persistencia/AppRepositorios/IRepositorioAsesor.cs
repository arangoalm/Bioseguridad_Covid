using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioAsesor
    {
        IEnumerable<Asesor> GetAllAsesores();
        Asesor GetAsesor(int idAsesor);
        Asesor AddAsesor(Asesor asesor);
        Asesor UpdateAsesor(Asesor asesor);
        void DeleteAsesor(int idAsesor);

    }
}