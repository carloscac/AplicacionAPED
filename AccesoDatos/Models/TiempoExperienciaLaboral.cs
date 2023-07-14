using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TiempoExperienciaLaboral
{
    public int IdTiempoExperienciaLaboral { get; set; }

    public string TieExpLabNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
