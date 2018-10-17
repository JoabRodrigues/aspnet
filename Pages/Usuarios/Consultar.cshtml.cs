using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstProject.Pages.Usuarios
{
    public class ConsultarModel : PageModel
    {
        public void OnGet()
        {
        }

        [HttpPost]
        public void OnPost(string Cpf){
            List<Usuario> Usuarios = CadastrarModel.Usuarios;

            foreach(Usuario Usuario in Usuarios){
                if (Cpf.Equals(Usuario.Cpf)){
                    ViewData["Usuario"] = Usuario;
                }
            }
        }
    }
}
