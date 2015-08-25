using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Amistad
    {
        public int Id { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Usuario UsuarioRelacionado { get; set; }
    }
}
