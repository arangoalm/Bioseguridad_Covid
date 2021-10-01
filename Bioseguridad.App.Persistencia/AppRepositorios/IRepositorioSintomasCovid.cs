using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioSintomasCovid
    {
        IEnumerable<SintomasCovid> GetAllSintomasCovids();
        SintomasCovid GetSintomasCovid(int idSintomasCovid);
        SintomasCovid AddSintomasCovid(SintomasCovid sintomasCovid);
        SintomasCovid UpdateSintomasCovid(SintomasCovid sintomasCovid);
        void DeleteSintomasCovid(int idSintomasCovid);

    }
}