using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string RolNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual Estado IdEstNavigation { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
