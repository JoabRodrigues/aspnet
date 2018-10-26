using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Data;
using FirstProject.Models;
using FirstProject.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstProject.Pages.Usuarios
{
    public class CadastrarModel : PageModel
    {

        FirstProjectContext _context;

        public CadastrarModel(FirstProjectContext context)
        {
            _context = context;
        }
        //public static List<Usuario> Usuarios = new List<Usuario>();

        [BindProperty(SupportsGet = true)]
        public Usuario Usuario { get; set; }

        public void OnGet()
        {
            if(Usuario == null){
                Usuario = new Usuario();
            }
        }

        [HttpPost]
        public IActionResult OnPost(){
            if(ModelState.IsValid){

                if (!DigitosUtil.IsCpf(Usuario.Cpf))
                {
                    ModelState.AddModelError("Usuario.Cpf", "Cpf inválido!");

                }

                Usuario user = _context.Usuario.Where(u => u.Email == Usuario.Email).FirstOrDefault();
                if(user != null)
                {
                    ModelState.AddModelError("", "Email já cadastrado.");
                }

                user = _context.Usuario.Where(u => u.Cpf == Usuario.Cpf).FirstOrDefault();
                if (user != null)
                {
                    ModelState.AddModelError("", "Cpf já cadastrado.");
                }

                if (ModelState.ErrorCount == 0)
                {
                    _context.Usuario.Add(Usuario);
                    _context.SaveChanges();
                    RedirectToPage("./Index");
                }

                return Page();
             }
            return Page();
        }
    }
}
