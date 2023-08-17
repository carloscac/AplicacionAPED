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

        List<OrientacionSexual> ListaOrientacionSexual();

        List<EstadoCivil> ListaEstadoCivil();
        List<Nacionalidad> ListaNacionalidad();
        List<GrupoEtnico> ListaGrupoEtnico();
        List<TipoPoblacion> ListaTipoPoblacion();
        List<CondicionDiscapacidad> ListaCondicionDiscapacidad();
        List<TipoPermisoTrabajo> ListaTipoPermisoTrabajo();

        List<TipoPersonaCuidado> ListoTipoPersonaCuidado();
    }
}