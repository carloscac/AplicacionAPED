using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoZona
{
    public int IdTipoZona { get; set; }

    public string TipZonNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
