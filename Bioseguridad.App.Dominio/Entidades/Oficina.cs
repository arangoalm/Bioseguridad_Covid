using System;


namespace Bioseguridad.App.Dominio
{
    public class Oficina //: SedeGobernacion
    {
        //public int id {get;set;}
        public string aforoHora {get;set;}
        public bool disponibilidad {get;set;}
        public System.Collections.Generic.List<Persona> persona {get;set;}
        public System.Collections.Generic.List<RegistroIngreso> registroIngreso {get;set;}
    }
}