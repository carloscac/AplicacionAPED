using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Localidad
{
    public int IdLocalidad { get; set; }

    public string LocNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public int? IdCiudad { get; set; }

    public virtual Ciudad? IdCiudadNavigation { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
