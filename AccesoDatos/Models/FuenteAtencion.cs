using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class FuenteAtencion
{
    public int IdFuenteAtencion { get; set; }

    public string FueAteNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
