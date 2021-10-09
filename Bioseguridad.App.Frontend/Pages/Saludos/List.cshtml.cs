using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bioseguridad.App.Dominio;
using Bioseguridad.App.Persistencia;

namespace Bioseguridad.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        //private string[] saludos = {"Buenos dias","Buenas Tardes","Buenas noches"};
        //public List<string> listaSaludos{get;set;}
        public readonly IRepositorioSaludos repositoriosaludos;
        public IEnumerable<Saludo> Saludos{get;set;}
        public ListModel(Saludo saludo, string filtro, DateTime filtroHora) 
        {
            this.Saludo = saludo;
                this.Filtro = filtro;
                this.FiltroHora = filtroHora;
               
        }
        public ListModel(Saludo saludo, string filtro, DateTime filtroHora) 
        {
            this.Saludo = saludo;
                this.Filtro = filtro;
                this.FiltroHora = filtroHora;
               
        }
                        public Saludo Saludo{get;set;}
        public string Filtro{get;set;}
        public DateTime FiltroHora{get;set;}
        public ListModel(IRepositorioSaludos repositoriosaludos)
        {
            this.repositoriosaludos=repositoriosaludos;
        }

        /*public void OnGet()
        {
            listaSaludos = new List<string>();
            listaSaludos.AddRange(saludos);
        }*/
        
        public void OnGet()
        {
            Saludos=repositoriosaludos.GetAll();
        }
        /*
        public void OnGet(string filtro)
        {
            Filtro = filtro;
            Saludos=repositoriosaludos.GetSaludosPorFiltro(filtro);
        }*/
        /*public void OnGet(DateTime filtroHora)
        {
            FiltroHora = filtroHora;
            Saludo=repositoriosaludos.GetSaludoHora(filtroHora);
        }*/
    }
}