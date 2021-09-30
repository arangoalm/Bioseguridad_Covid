using System;


namespace Bioseguridad.App.Dominio
{
    public class Oficina : SedeGobernacion
    {
        public int id {get;set;}
        public string aforoHora {get;set;}
        public bool disponibilidad {get;set;}
        
    }
}