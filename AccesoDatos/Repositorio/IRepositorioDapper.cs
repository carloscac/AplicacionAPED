using Dominio.ModelosDominio;

namespace AccesoDatos.Repositorio
{
    public interface IRepositorioDapper
    {
        ProspectoDTO ConsultaProspecto(string numeroIdentificacion);
        List<ProspectoDTO> ListaProspectos();
    }
}