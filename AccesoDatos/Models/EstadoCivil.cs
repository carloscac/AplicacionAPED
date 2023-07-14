using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class EstadoCivil
{
    public int IdEstadoCivil { get; set; }

    public string EstCivNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
