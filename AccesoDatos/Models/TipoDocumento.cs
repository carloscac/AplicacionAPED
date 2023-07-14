using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoDocumento
{
    public int IdTipoDocumento { get; set; }

    public string TipDocNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
