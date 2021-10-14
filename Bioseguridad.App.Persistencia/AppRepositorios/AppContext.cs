using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using Bioseguridad.App.Dominio;


namespace Bioseguridad.App.Persistencia 
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> personas {get;set;}
        public DbSet<Oficina> oficinas {get;set;}
        public DbSet<SedeGobernacion> sedeGobernacion {get;set;}
        public DbSet<SintomasCovid> sintomasCovid {get;set;}
        public DbSet<RegistroIngreso> registroIngreso {get;set;}
        public DbSet<Asesor> asesores {get;set;}
        public DbSet<Gobernador> gobernadores {get;set;}
        public DbSet<PersonalAseo> personalAseo {get;set;}
        public DbSet<ProveedorServicio> proveedorServicios {get;set;}
        public DbSet<SecretarioDespacho> secretarioDespacho {get;set;}
        public DbSet<Saludo> saludos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB; Initial Catalog = BioseguridadCovid");
            }
        }
    }
}