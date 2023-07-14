using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class CertificadoPoblacional
{
    public int IdCertificadoPoblacional { get; set; }

    public string CerPobNombre { get; set; } = null!;

    public int IdEst { get; set; }

    public virtual ICollection<Prospecto> Prospectos { get; set; } = new List<Prospecto>();
}
