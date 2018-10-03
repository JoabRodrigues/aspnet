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
        public Usuario usuario;

        public void OnGet(string nome, string senha)
        {
            usuario = new Usuario
            {
                Nome = nome,
                Senha = senha
            };
        }
    }
}
