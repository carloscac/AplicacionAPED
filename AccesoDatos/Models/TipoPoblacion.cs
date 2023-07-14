using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoPoblacion
{
    public int IdTipoPoblacion { get; set; }

    public string TipPobNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
