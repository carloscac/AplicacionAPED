using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class IdentidadGenero
{
    public int IdIdentidadGenero { get; set; }

    public string IdeGenNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
