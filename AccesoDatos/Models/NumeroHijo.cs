using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class NumeroHijo
{
    public int IdNumeroHijos { get; set; }

    public string NumHijNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
