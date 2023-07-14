using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class GrupoEtnico
{
    public int IdGrupoEtnico { get; set; }

    public string GruEtnNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
