using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class VehiculoPropio
{
    public int IdVehiculoPropio { get; set; }

    public string VehProNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
