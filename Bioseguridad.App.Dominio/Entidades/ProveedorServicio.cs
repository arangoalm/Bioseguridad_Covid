using System;


namespace Bioseguridad.App.Dominio
{
    public class ProveedorServicio : Persona
    {
        public int id {get;set;}
        public string servicioRealizado {get;set;}
        public string unidadServicoRealizado {get; set;}
    }
}