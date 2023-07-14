using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoPermisoTrabajo
{
    public int IdTipoPermisoTrabajo { get; set; }

    public string TipPerTraNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
