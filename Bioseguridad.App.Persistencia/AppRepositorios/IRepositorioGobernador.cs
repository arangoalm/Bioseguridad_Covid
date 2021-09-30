using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioGobernador
    {
        IEnumerable<Gobernador> GetAllGobernadores();
        Asesor GetGobernador(int idGobernador);
        Asesor AddGobernador(Gobernador gobernador);
        Asesor UpdateGobernador(Gobernador gobernador);
        void DeleteGobernador(int idGobernador);

    }
}