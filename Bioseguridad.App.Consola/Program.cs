using System;
using Bioseguridad.App.Dominio;
using Bioseguridad.App.Persistencia;
using System.Collections.Generic;

namespace Bioseguridad.App.Consola
{
    class Program
    {
        private static IRepositorioAsesor _repoAsesor = new RepositorioAsesor(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarAsesor();
            ActualizarAsesor(1);
            EncontrarAsesor(1);
            EncontrarAsesores();
            EliminarAsesor(1);

        }
    //CRUD
    //AdicionarAsesor

        private static void AdicionarAsesor()
        {

            var asesor = new Asesor
            {
                nombre = "Almeiro",
                apellidos = "Arango Avila",
                identificacion = "1234564566",
                edad = "42",
                profesion = "Ingniero en sistemas",
                oficinaVisitada = "301"

            };

            _repoAsesor.AddAsesor(asesor);
        }

    //ActualizarAsesor
        private static void ActualizarAsesor(int idAsesor)
        {
            var asesor = new Asesor
            {
                id=idAsesor,
                nombre = "Julio",
                apellidos = "Perez",
                identificacion = "1234545876",
                edad = "35",
                profesion = "Ingeniero electrico",
                oficinaVisitada = "301"
            
            };

            Asesor asesorActualizado=_repoAsesor.UpdateAsesor(asesor);
            if (asesorActualizado!=null)
                Console.WriteLine("Se actualizo el asesor");
                    
        }

    //EncontrarAsesor
        private static void EncontrarAsesor(int idAsesor)
        {
            var asesorEncontrado = _repoAsesor.GetAsesor(idAsesor);
            Console.WriteLine(asesorEncontrado.nombre);
            
        }
//EncontrarAsesores
        private static void EncontrarAsesores()
        {
            IEnumerable<Asesor> asesores = _repoAsesor.GetAllAsesores(idAsesor);
            foreach (var asesor in asesores)
            {
                Console.WriteLine(asesor.nombre+" "+asesor.apellidos+" "+asesor.oficinaVisitada);
            }
//EliminarAsesore
        private static void EliminarAsesor(int idAsesor)
        {
            bool bandera=_repoAsesor.DeleteAsesor(idAsesor);
            if (bandera)
            Console.WriteLine("Se elimino correctamente");
            else
            {
                Console.WriteLine("Error al acceder a la base de datos");
            }
        }        
    }

   


}
