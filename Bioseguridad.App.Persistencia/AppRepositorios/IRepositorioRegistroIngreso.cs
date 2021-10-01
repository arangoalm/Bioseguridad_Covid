using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioRegistroIngreso
    {
        IEnumerable<RegistroIngreso> GetAllRegistroIngresos();
        RegistroIngreso GetRegistroIngreso(int idRegistroIngreso);
        RegistroIngreso AddRegistroIngreso(RegistroIngreso registroIngreso);
        RegistroIngreso UpdateRegistroIngreso(RegistroIngreso registroIngreso);
        void DeleteRegistroIngreso(int idRegistroIngreso);

    }
}