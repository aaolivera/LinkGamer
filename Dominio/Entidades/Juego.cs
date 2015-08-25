using System.ComponentModel.DataAnnotations;
using Dominio.Enum;

namespace Dominio.Entidades
{
    public class Juego : IIdentificable
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
