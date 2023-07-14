using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Sexo
{
    public int IdSexo { get; set; }

    public string SexNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
