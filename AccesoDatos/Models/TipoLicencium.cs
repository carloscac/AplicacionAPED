using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class TipoLicencium
{
    public int IdTipoLicencia { get; set; }

    public string TipLicNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<CategoriaLicencium> CategoriaLicencia { get; set; } = new List<CategoriaLicencium>();
}
