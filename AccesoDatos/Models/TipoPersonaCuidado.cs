using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoPersonaCuidado
{
    public int IdTipoPersonaCuidado { get; set; }

    public string TipPerCuiNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
