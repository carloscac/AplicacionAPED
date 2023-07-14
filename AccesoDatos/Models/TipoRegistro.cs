using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoRegistro
{
    public int IdTipoRegistro { get; set; }

    public string TipRegNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
