using Dominio.ModelosDominio;
using System.Collections.Generic;

namespace AccesoDatos.Repositorio
{
    public interface IRepositorioDapper
    {
        ProspectoDTO ConsultaProspecto(string numeroIdentificacion);
        List<ProspectoDTO> ListaProspectos();
    }
}