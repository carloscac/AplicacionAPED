using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string ProNombre { get; set; } = null!;

    public string ProUsuarioApp { get; set; } = null!;

    public string ProContrasena { get; set; } = null!;

    public int IdRol { get; set; }

    public int IdEstado { get; set; }

    public string? EstCorreoElectronico { get; set; }

    public DateTime ProFechaCreacion { get; set; }

    public string ProUsuarioCreacion { get; set; } = null!;

    public DateTime ProFechaModificacion { get; set; }

    public string ProUsuarioModificacion { get; set; } = null!;

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual Rol IdRolNavigation { get; set; } = null!;
}
