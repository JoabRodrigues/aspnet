using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstProject.Data;
using FirstProject.Models;

namespace FirstProject.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly FirstProject.Models.FirstProjectContext _context;

        public IndexModel(FirstProject.Models.FirstProjectContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
