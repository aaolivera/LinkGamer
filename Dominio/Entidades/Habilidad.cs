using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio.Entidades
{
    public class Habilidad : IIdentificable
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual Juego Juego { get; set; }
        public virtual List<Usuario> Certificadores { get; set; }
    }
}
