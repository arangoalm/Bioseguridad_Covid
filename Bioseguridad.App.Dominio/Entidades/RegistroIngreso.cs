using System;


namespace Bioseguridad.App.Dominio
{
    public class RegistroIngreso
    {
        public int id {get;set;}
        public date fechaIngreso {get;set;}
        public time horaIngreso {get;set;}
        public Persona persona {get;set;}
        public SintomasCovid sintomasCovid {get;set;}
        
    }
}