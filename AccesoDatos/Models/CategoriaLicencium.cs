using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class CategoriaLicencium
{
    public int IdCategoriaLicencia { get; set; }

    public string CatLicNombre { get; set; } = null!;

    public int IdTipoLicencia { get; set; }

    public int IdEst { get; set; }

    public virtual TipoLicencium IdTipoLicenciaNavigation { get; set; } = null!;

    public virtual ICollection<Prospecto> ProspectoIdCategoriaLicenciaCarroNavigations { get; set; } = new List<Prospecto>();

    public virtual ICollection<Prospecto> ProspectoIdCategoriaLicenciaMotoNavigations { get; set; } = new List<Prospecto>();
}
