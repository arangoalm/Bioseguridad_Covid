using System;
using System.Collections.Generic;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Persistencia
{
    public interface IRepositorioSecretarioDespacho
    {
        IEnumerable<SecretarioDespacho> GetAllSecretarioDespachos();
        SecretarioDespacho GetSecretarioDespacho(int idSecretarioDespacho);
        SecretarioDespacho AddSecretarioDespacho(SecretarioDespacho secretarioDespacho);
        SecretarioDespacho UpdateSecretarioDespacho(SecretarioDespacho secretarioDespacho);
        void DeleteSecretarioDespacho(int idSecretarioDespacho);

    }
}