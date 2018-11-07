using FirstProject.Data;
using FirstProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Business
{
    public class JogoService : IJogoService
    {
        FirstProjectContext _context;

        public JogoService(FirstProjectContext context)
        {
            _context = context;
        }

        public List<Mesa> ListarMesa(int usuarioId)
        {
            List<MesaUsuario> mesasUsuarios = _context.MesasUsuarios.Include(mu => mu.Mesa).Where(mu => mu.UsuarioId == usuarioId).ToList();

            List<Mesa> mesas = new List<Mesa>();

            foreach(MesaUsuario mu in mesasUsuarios)
            {
                mesas.Add(mu.Mesa);
            }

            return mesas;
        }

        public void MontarMesa(string nome, int usuarioId)
        {
            Mesa mesa = new Mesa { Nome = nome };
            MesaUsuario mesaUsuario = new MesaUsuario
            {
                UsuarioId = usuarioId,
                Mesa = mesa
            };
            _context.MesasUsuarios.Add(mesaUsuario);
            _context.SaveChanges();
        }
    }

    public interface IJogoService
    {
        List<Mesa> ListarMesa(int usuarioId);
        void MontarMesa(string nome, int usuarioId);
    }
}
