using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstProject.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Usuario Usuario { get; set; }

        public void OnGet()
        {
            if(Usuario == null){
                Usuario = new Usuario();
            }
        }
    }
}
