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
    public class DetallesModel : PageModel
    {
        public readonly IRepositorioSaludos repositoriosaludos;
        public Saludo Saludo;
        public DetallesModel(IRepositorioSaludos repositoriosaludos)
        {
            this.repositoriosaludos = repositoriosaludos;
        }

        public IActionResult OnGet(int saludoId)
        {
            Saludo = repositoriosaludos.GetSaludoId(saludoId);
            if(Saludo==null)
            {
                return RedirectToPage("./List");
            }else
            return Page();
        }
    }
}