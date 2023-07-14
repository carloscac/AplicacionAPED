using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public string CiuNombre { get; set; } = null!;

    public string CiuCodigoDane { get; set; } = null!;

    public bool? CiuResidenciaHabilitada { get; set; }

    public int IdEst { get; set; }

    public virtual ICollection<Localidad> Localidads { get; set; } = new List<Localidad>();

    public virtual ICollection<Prospecto> ProspectoIdCiudadExpedicionNavigations { get; set; } = new List<Prospecto>();

    public virtual ICollection<Prospecto> ProspectoIdCiudadResidenciaNavigations { get; set; } = new List<Prospecto>();
}
