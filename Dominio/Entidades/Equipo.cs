using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Equipo : IIdentificable
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual List<Usuario> Usuarios { get; set; }
        public virtual Juego Juego { get; set; }
    }
}
