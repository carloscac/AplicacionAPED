using System.ComponentModel;

namespace APEDI.Models
{
    public class ProspectoModel
    {

        public int IdProspecto { get; set; }

        [DisplayName("Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        public int IdTipoRegistro { get; set; }

        public int? IdFuente { get; set; }

        public int? IdBasesPoliticasPublicas { get; set; }

        public string? NombreCodigoEvento { get; set; }

        public int? IdModoAtencion { get; set; }

        public int? IdProfesionalRegistro { get; set; }

        public string? OtroProfesional { get; set; }

        public int? IdTipoDocumento { get; set; }

        public string? NumeroIdentificacion { get; set; }

        public string? NombresCompleto { get; set; }

        public string? NombreIdentatario { get; set; }

        public DateTime? FechaExpedición { get; set; }

        public int? IdCiudadExpedicion { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public int? IdSexo { get; set; }

        public string? LibretaMilitar { get; set; }

        public int? IdCiudadResidencia { get; set; }

        public int? IdLocalidad { get; set; }

        public string? Barrio { get; set; }

        public int? IdTipoZona { get; set; }

        public string? DireccionResidencia { get; set; }

        public string? Contacto1 { get; set; }

        public string? Contacto2 { get; set; }

        public string? Email { get; set; }

        public int? IdIdentidadGenero { get; set; }

        public int? IdOrientacionSexual { get; set; }

        public int? IdEstadoCivil { get; set; }

        public int? IdNacionalidad { get; set; }

        public int? IdGrupoEtnico { get; set; }

        public int? IdTipoPoblacion { get; set; }

        public int? IdCondicionDiscapacidad { get; set; }

        public int? IdCertificadoPoblacional { get; set; }

        public bool? PoblacionMigrante { get; set; }

        public bool? TituloEstudioApostillado { get; set; }

        public string? NombreTituloApostillado { get; set; }

        public bool? PermisoTrabajo { get; set; }

        public int? IdTipoPermisoTrabajo { get; set; }

        public bool? ConoceTramite { get; set; }

        public bool? JefeHogar { get; set; }

        public string? PersonasDependenEconomicamente { get; set; }

        public bool? TieneHijos { get; set; }

        public int? IdNumeroHijos { get; set; }

        public bool? TienePersonasAcargo { get; set; }

        public int? IdTipoPersonaCuidado { get; set; }

        public bool? LicenciaConduccionCarro { get; set; }

        public int? IdCategoriaLicenciaCarro { get; set; }

        public bool? LicenciaConduccionMoto { get; set; }

        public int? IdCategoriaLicenciaMoto { get; set; }

        public int? IdVehiculoPropio { get; set; }

        public int? IdSituacionActual { get; set; }

        public int? IdTiempoCesante { get; set; }

        public bool? ExperienciaLaboral { get; set; }

        public string? UltimaExperienciaLaboral { get; set; }

        public int? IdExperienciaLaboral { get; set; }

        public bool? DocumentosCertificanExperiencia { get; set; }

        public bool? ContinuarProcesoOrientacion { get; set; }

        public int? IdMotivoNoContinuar { get; set; }

        public int? IdUsuarioCreación { get; set; }

        public int? IdUsuarioModifcacion { get; set; }

        public DateTime? FechaCreación { get; set; }

        public int? IdEstado { get; set; }

        public DateTime? FechaModificación { get; set; }

        public string? CiudadNacimiento { get; set; }

        public string? Ciudad { get; set; }
    }
}
