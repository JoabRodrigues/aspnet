using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Data
{
    public class Mesa
    {
        public int MesaId { get; set; }
        public string Nome { get; set; }
        public ICollection<MesaUsuario> MesasUsuarios { get; set; }
    }

    public class MesaUsuario
    {
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }   
    }
}
