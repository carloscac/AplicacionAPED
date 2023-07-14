using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TiempoCesante
{
    public int IdTiempoCesante { get; set; }

    public string TieCesNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
