using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioPersonalAseo
    {
        IEnumerable<PersonalAseo> GetAllPersonalAseo();
        PersonalAseo GetPersonalAseo(int idPersonalAseo);
        PersonalAseo AddPersonalAseo(PersonalAseo personalAseo);
        PersonalAseo UpdatePersonalAseo(PersonalAseo personalAseo);
        void DeletePersonalAseo(int idPersonalAseo);

    }
}