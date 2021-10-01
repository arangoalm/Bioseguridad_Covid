using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioGobernador
    {
        IEnumerable<Gobernador> GetAllGobernadores();
        Gobernador GetGobernador(int idGobernador);
        Gobernador AddGobernador(Gobernador gobernador);
        Gobernador UpdateGobernador(Gobernador gobernador);
        void DeleteGobernador(int idGobernador);

    }
}