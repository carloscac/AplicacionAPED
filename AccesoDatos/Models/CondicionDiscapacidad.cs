using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class CondicionDiscapacidad
{
    public int IdCondicionDiscapacidad { get; set; }

    public string ConDisNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
