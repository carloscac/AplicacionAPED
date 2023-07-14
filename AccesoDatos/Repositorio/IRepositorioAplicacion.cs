using AccesoDatos.Models;

namespace AccesoDatos.Repositorio
{
    public interface IRepositorioAplicacion
    {
        Prospecto ActualizarProspecto(Prospecto prospecto);
        Prospecto ConsultaPorId(string idDocumento);
        void CrearProspecto(Prospecto prospecto);
        void EliminarProspecto(int idProspecto);
        List<CategoriaLicencium> LisaCategoriaLicencia();
        List<BasePoliticaPublica> ListaBasePolitica();
        List<CertificadoPoblacional> ListaCertificadoPoblacional();
        List<Prospecto> ListaProspectos();
    }
}