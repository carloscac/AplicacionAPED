using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Nacionalidad
{
    public int IdNacionalidad { get; set; }

    public string NacNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
