using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class MotivoNoContinua
{
    public int IdMotivoNoContinua { get; set; }

    public string MotNoContNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
