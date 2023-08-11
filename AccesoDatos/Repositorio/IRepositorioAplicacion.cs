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

        List<TipoRegistro> ListaTipoRegistro();
        List<FuenteAtencion> ListaTipoFuente();
        List<ModoAtencion> ListaModoAtencion();
        List<ProfesionalRegistro> ListaProfesional();
        List<TipoDocumento> ListaTipoDoc();

        List<Ciudad> ListaCiudad();
        List<Sexo> ListaSexo();
        List<Localidad> ListaLocalidad();
        List<TipoZona> ListaTipoZona();
        List<IdentidadGenero> ListaIdentidadGenero();
    }
}