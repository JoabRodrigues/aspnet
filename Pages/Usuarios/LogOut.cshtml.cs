using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;



namespace FirstProject.Pages.Usuarios
{
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {

            HttpContext.Session.Clear();

            return RedirectToPage("./Login");

        }
    }
}