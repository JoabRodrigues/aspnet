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
        public DbSet<FirstProject.Data.Mesa> Mesas { get; set; }
        public DbSet<FirstProject.Data.MesaUsuario> MesasUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MesaUsuario>().HasKey(um => new { um.MesaId, um.UsuarioId });

            modelBuilder.Entity<MesaUsuario>().HasOne(um => um.Mesa).WithMany(m => m.MesasUsuarios).HasForeignKey(um => um.MesaId);

            modelBuilder.Entity<MesaUsuario>().HasOne(um => um.Usuario).WithMany(u => u.MesasUsuarios).HasForeignKey(um => um.UsuarioId);
        }
    }
}
