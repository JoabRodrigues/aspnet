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
        [BindProperty]
        public Usuario Usuario { get; set; }

        public void OnGet(string nome, string senha)
        {
            if(Usuario == null ){
                Usuario = new Usuario();
            }
            Usuario.Nome = nome;
            Usuario.Senha = senha;
        }
    }
}
