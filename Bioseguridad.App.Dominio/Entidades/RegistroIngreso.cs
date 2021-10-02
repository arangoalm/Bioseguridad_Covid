using System;


namespace Bioseguridad.App.Dominio
{
    public class RegistroIngreso
    {
        public int id {get;set;}
        public DateTime fechaIngreso {get;set;}
        public DateTime horaIngreso {get;set;}
        public Persona persona {get;set;}
        public SintomasCovid sintomasCovid {get;set;}
    }
}