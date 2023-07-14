using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class ProfesionalRegistro
{
    public int IdProfesionalRegistro { get; set; }

    public string ProRegNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
