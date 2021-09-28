using System;

namespace Bioseguridad.App.Dominio
{
 
    public class Persona
    {
        // Identificador único de cada persona
        public int id {get;set;}
        public string nombre {get;set;}
        public string apellidos {get;set;}
        public int identificacion {get;set;}
        public int edad {get;set;}
        public string profesion {get;set;}
        public EstadoCovid estadoCovid {get;set;}
        
    }
}