using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string EstNombre { get; set; } = null!;

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
