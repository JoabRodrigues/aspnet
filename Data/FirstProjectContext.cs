using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstProject.Data;

namespace FirstProject.Models
{
    public class FirstProjectContext : DbContext
    {
        public FirstProjectContext (DbContextOptions<FirstProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FirstProject.Data.Usuario> Usuario { get; set; }
    }
}
