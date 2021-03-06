using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bioseguridad.App.Persistencia;
using Bioseguridad.App.Dominio;

namespace Bioseguridad.App.Frontend.Pages
{
        private readonly IRepositorioSaludos repositoriosaludos;
        [BindProperty]
        public Saludo Saludo{get;set;}

        public EliminarModel(IRepositorioSaludos repositoriosaludos)
        {
            this.repositoriosaludos = repositoriosaludos;
        }

        public IActionResult OnGet(int SaludoId)
        {
            Saludo = repositoriosaludos.GetSaludoId(SaludoId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoriosaludos.Delete(Saludo);
            return RedirectToPage("./List");        }
    }
}
