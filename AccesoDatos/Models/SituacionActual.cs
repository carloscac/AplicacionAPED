using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class SituacionActual
{
    public int IdSituacionActual { get; set; }

    public string SitActNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
