using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class BasePoliticaPublica
{
    public int IdBasePoliticaPublica { get; set; }

    public string BasPolPubNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
