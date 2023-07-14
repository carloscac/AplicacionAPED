using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class ModoAtencion
{
    public int IdModoAtencion { get; set; }

    public string ModAteNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
