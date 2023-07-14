using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class OrientacionSexual
{
    public int IdOrientacionSexual { get; set; }

    public string OriSexNombre { get; set; } = null!;

    public int IdEst { get; set; }
}
