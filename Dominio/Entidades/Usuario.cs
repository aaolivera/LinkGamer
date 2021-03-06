﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    public class Usuario : IIdentificable
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string NombreUsuario { get; set; }
        public virtual string Email { get; set; }
        public virtual ICollection<Habilidad> Habilidades { get; set; }
        [InverseProperty("Usuario")]
        public virtual ICollection<Amistad> Amigos { get; set; }
        public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
