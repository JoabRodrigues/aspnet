using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Data;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstProject.Pages.Usuarios
{
    public class ConsultarModel : PageModel
    {
        FirstProjectContext _context;

        public ConsultarModel(FirstProjectContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        [HttpPost]
        public void OnPost(string Cpf){
            Usuario u = _context.Usuario
                .Where(u1 => u1.Cpf == Cpf).FirstOrDefault();
            if (u != null)
            {
                ViewData["usuario"] = u;
            }
        }
    }
}
