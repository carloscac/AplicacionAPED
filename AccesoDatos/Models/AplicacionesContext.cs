using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Models;

public partial class AplicacionesContext : DbContext
{
    public AplicacionesContext()
    {
    }

    public AplicacionesContext(DbContextOptions<AplicacionesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BasePoliticaPublica> BasePoliticaPublicas { get; set; }

    public virtual DbSet<CategoriaLicencium> CategoriaLicencia { get; set; }

    public virtual DbSet<CertificadoPoblacional> CertificadoPoblacionals { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<CondicionDiscapacidad> CondicionDiscapacidads { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }

    public virtual DbSet<FuenteAtencion> FuenteAtencions { get; set; }

    public virtual DbSet<GrupoEtnico> GrupoEtnicos { get; set; }

    public virtual DbSet<IdentidadGenero> IdentidadGeneros { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<ModoAtencion> ModoAtencions { get; set; }

    public virtual DbSet<MotivoNoContinua> MotivoNoContinuas { get; set; }

    public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }

    public virtual DbSet<NumeroHijo> NumeroHijos { get; set; }

    public virtual DbSet<OrientacionSexual> OrientacionSexuals { get; set; }

    public virtual DbSet<ProfesionalRegistro> ProfesionalRegistros { get; set; }

    public virtual DbSet<Prospecto> Prospectos { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<SituacionActual> SituacionActuals { get; set; }

    public virtual DbSet<TiempoCesante> TiempoCesantes { get; set; }

    public virtual DbSet<TiempoExperienciaLaboral> TiempoExperienciaLaborals { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoLicencium> TipoLicencia { get; set; }

    public virtual DbSet<TipoPermisoTrabajo> TipoPermisoTrabajos { get; set; }

    public virtual DbSet<TipoPersonaCuidado> TipoPersonaCuidados { get; set; }

    public virtual DbSet<TipoPoblacion> TipoPoblacions { get; set; }

    public virtual DbSet<TipoRegistro> TipoRegistros { get; set; }

    public virtual DbSet<TipoZona> TipoZonas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VehiculoPropio> VehiculoPropios { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=PCCARLOS\\SQLEXPRESS; Initial Catalog=Aplicaciones; User=UsuarioRegistro; Password=12345678; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BasePoliticaPublica>(entity =>
        {
            entity.HasKey(e => e.IdBasePoliticaPublica).HasName("PK_idBasePoliticaPublica");

            entity.ToTable("BasePoliticaPublica", "aped");

            entity.Property(e => e.IdBasePoliticaPublica).HasColumnName("idBasePoliticaPublica");
            entity.Property(e => e.BasPolPubNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<CategoriaLicencium>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaLicencia).HasName("PK_idCategoriaLicencia");

            entity.ToTable("CategoriaLicencia", "aped");

            entity.Property(e => e.IdCategoriaLicencia).HasColumnName("idCategoriaLicencia");
            entity.Property(e => e.CatLicNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.IdTipoLicencia).HasColumnName("idTipoLicencia");

            entity.HasOne(d => d.IdTipoLicenciaNavigation).WithMany(p => p.CategoriaLicencia)
                .HasForeignKey(d => d.IdTipoLicencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaLicencia_TipoLicencia");
        });

        modelBuilder.Entity<CertificadoPoblacional>(entity =>
        {
            entity.HasKey(e => e.IdCertificadoPoblacional).HasName("PK_idCertificadoPoblacional");

            entity.ToTable("CertificadoPoblacional", "aped");

            entity.Property(e => e.IdCertificadoPoblacional).HasColumnName("idCertificadoPoblacional");
            entity.Property(e => e.CerPobNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.HasKey(e => e.IdCiudad).HasName("PK_idCiudad");

            entity.ToTable("Ciudad", "aped");

            entity.Property(e => e.IdCiudad).HasColumnName("idCiudad");
            entity.Property(e => e.CiuCodigoDane)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CiuCodigoDANE");
            entity.Property(e => e.CiuNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<CondicionDiscapacidad>(entity =>
        {
            entity.HasKey(e => e.IdCondicionDiscapacidad).HasName("PK_idCondicionDiscapacidad");

            entity.ToTable("CondicionDiscapacidad", "aped");

            entity.Property(e => e.IdCondicionDiscapacidad).HasColumnName("idCondicionDiscapacidad");
            entity.Property(e => e.ConDisNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK_idEstado");

            entity.ToTable("Estado", "aped");

            entity.Property(e => e.IdEstado).HasColumnName("idEstado");
            entity.Property(e => e.EstNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EstadoCivil>(entity =>
        {
            entity.HasKey(e => e.IdEstadoCivil).HasName("PK_idEstadoCivil");

            entity.ToTable("EstadoCivil", "aped");

            entity.Property(e => e.IdEstadoCivil).HasColumnName("idEstadoCivil");
            entity.Property(e => e.EstCivNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<FuenteAtencion>(entity =>
        {
            entity.HasKey(e => e.IdFuenteAtencion).HasName("PK_idFuenteAtencion");

            entity.ToTable("FuenteAtencion", "aped");

            entity.Property(e => e.IdFuenteAtencion).HasColumnName("idFuenteAtencion");
            entity.Property(e => e.FueAteNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<GrupoEtnico>(entity =>
        {
            entity.HasKey(e => e.IdGrupoEtnico).HasName("PK_idGrupoEtnico");

            entity.ToTable("GrupoEtnico", "aped");

            entity.Property(e => e.IdGrupoEtnico).HasColumnName("idGrupoEtnico");
            entity.Property(e => e.GruEtnNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdEst).HasColumnName("idEst");
        });

        modelBuilder.Entity<IdentidadGenero>(entity =>
        {
            entity.HasKey(e => e.IdIdentidadGenero).HasName("PK_idIdentidadGenero");

            entity.ToTable("IdentidadGenero", "aped");

            entity.Property(e => e.IdIdentidadGenero).HasColumnName("idIdentidadGenero");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.IdeGenNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.IdLocalidad).HasName("PK_idLocalidad");

            entity.ToTable("Localidad", "aped");

            entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.LocNombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Localidads).HasForeignKey(d => d.IdCiudad);
        });

        modelBuilder.Entity<ModoAtencion>(entity =>
        {
            entity.HasKey(e => e.IdModoAtencion).HasName("PK_idModoAtencion");

            entity.ToTable("ModoAtencion", "aped");

            entity.Property(e => e.IdModoAtencion).HasColumnName("idModoAtencion");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.ModAteNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MotivoNoContinua>(entity =>
        {
            entity.HasKey(e => e.IdMotivoNoContinua).HasName("PK_idMotivoNoContinua");

            entity.ToTable("MotivoNoContinua", "aped");

            entity.Property(e => e.IdMotivoNoContinua).HasColumnName("idMotivoNoContinua");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.MotNoContNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Nacionalidad>(entity =>
        {
            entity.HasKey(e => e.IdNacionalidad).HasName("PK_idNacionalidad");

            entity.ToTable("Nacionalidad", "aped");

            entity.Property(e => e.IdNacionalidad).HasColumnName("idNacionalidad");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.NacNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NumeroHijo>(entity =>
        {
            entity.HasKey(e => e.IdNumeroHijos).HasName("PK_idNumeroHijos");

            entity.ToTable("NumeroHijos", "aped");

            entity.Property(e => e.IdNumeroHijos).HasColumnName("idNumeroHijos");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.NumHijNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrientacionSexual>(entity =>
        {
            entity.HasKey(e => e.IdOrientacionSexual).HasName("PK_idOrientacionSexual");

            entity.ToTable("OrientacionSexual", "aped");

            entity.Property(e => e.IdOrientacionSexual).HasColumnName("idOrientacionSexual");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.OriSexNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProfesionalRegistro>(entity =>
        {
            entity.HasKey(e => e.IdProfesionalRegistro).HasName("PK_idProfesionalRegistro");

            entity.ToTable("ProfesionalRegistro", "aped");

            entity.Property(e => e.IdProfesionalRegistro).HasColumnName("idProfesionalRegistro");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.ProRegNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prospecto>(entity =>
        {
            entity.HasKey(e => e.IdProspecto).HasName("PK_idProspecto");

            entity.ToTable("Prospecto", "aped");

            entity.Property(e => e.IdProspecto).HasColumnName("idProspecto");
            entity.Property(e => e.Barrio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contacto1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Contacto2)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DireccionResidencia)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreación).HasColumnType("datetime");
            entity.Property(e => e.FechaExpedición).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.IdBasesPoliticasPublicas).HasColumnName("idBasesPoliticasPublicas");
            entity.Property(e => e.IdCategoriaLicenciaCarro).HasColumnName("idCategoriaLicenciaCarro");
            entity.Property(e => e.IdCategoriaLicenciaMoto).HasColumnName("idCategoriaLicenciaMoto");
            entity.Property(e => e.IdCertificadoPoblacional).HasColumnName("idCertificadoPoblacional");
            entity.Property(e => e.IdCiudadExpedicion).HasColumnName("idCiudadExpedicion");
            entity.Property(e => e.IdCiudadResidencia).HasColumnName("idCiudadResidencia");
            entity.Property(e => e.IdCondicionDiscapacidad).HasColumnName("idCondicionDiscapacidad");
            entity.Property(e => e.IdEstado).HasColumnName("idEstado");
            entity.Property(e => e.IdEstadoCivil).HasColumnName("idEstadoCivil");
            entity.Property(e => e.IdExperienciaLaboral).HasColumnName("idExperienciaLaboral");
            entity.Property(e => e.IdFuente).HasColumnName("idFuente");
            entity.Property(e => e.IdGrupoEtnico).HasColumnName("idGrupoEtnico");
            entity.Property(e => e.IdIdentidadGenero).HasColumnName("idIdentidadGenero");
            entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");
            entity.Property(e => e.IdModoAtencion).HasColumnName("idModoAtencion");
            entity.Property(e => e.IdMotivoNoContinuar).HasColumnName("idMotivoNoContinuar");
            entity.Property(e => e.IdNacionalidad).HasColumnName("idNacionalidad");
            entity.Property(e => e.IdNumeroHijos).HasColumnName("idNumeroHijos");
            entity.Property(e => e.IdOrientacionSexual).HasColumnName("idOrientacionSexual");
            entity.Property(e => e.IdProfesionalRegistro).HasColumnName("idProfesionalRegistro");
            entity.Property(e => e.IdSexo).HasColumnName("idSexo");
            entity.Property(e => e.IdSituacionActual).HasColumnName("idSituacionActual");
            entity.Property(e => e.IdTiempoCesante).HasColumnName("idTiempoCesante");
            entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");
            entity.Property(e => e.IdTipoPermisoTrabajo).HasColumnName("idTipoPermisoTrabajo");
            entity.Property(e => e.IdTipoPersonaCuidado).HasColumnName("idTipoPersonaCuidado");
            entity.Property(e => e.IdTipoPoblacion).HasColumnName("idTipoPoblacion");
            entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");
            entity.Property(e => e.IdTipoZona).HasColumnName("idTipoZona");
            entity.Property(e => e.IdUsuarioCreación).HasColumnName("idUsuarioCreación");
            entity.Property(e => e.IdUsuarioModifcacion).HasColumnName("idUsuarioModifcacion");
            entity.Property(e => e.IdVehiculoPropio).HasColumnName("idVehiculoPropio");
            entity.Property(e => e.LibretaMilitar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCodigoEvento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreIdentatario)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreTituloApostillado)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombresCompleto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.OtroProfesional)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PersonasDependenEconomicamente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TienePersonasAcargo).HasColumnName("TienePersonasACargo");
            entity.Property(e => e.UltimaExperienciaLaboral)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdBasesPoliticasPublicasNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdBasesPoliticasPublicas)
                .HasConstraintName("FK_Prospecto_BasePoliticaPublica");

            entity.HasOne(d => d.IdCategoriaLicenciaCarroNavigation).WithMany(p => p.ProspectoIdCategoriaLicenciaCarroNavigations)
                .HasForeignKey(d => d.IdCategoriaLicenciaCarro)
                .HasConstraintName("FK_Prospecto_CategoriaLicencia");

            entity.HasOne(d => d.IdCategoriaLicenciaMotoNavigation).WithMany(p => p.ProspectoIdCategoriaLicenciaMotoNavigations)
                .HasForeignKey(d => d.IdCategoriaLicenciaMoto)
                .HasConstraintName("FK_Prospecto_CategoriaLicencia1");

            entity.HasOne(d => d.IdCertificadoPoblacionalNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdCertificadoPoblacional)
                .HasConstraintName("FK_Prospecto_CertificadoPoblacional");

            entity.HasOne(d => d.IdCiudadExpedicionNavigation).WithMany(p => p.ProspectoIdCiudadExpedicionNavigations)
                .HasForeignKey(d => d.IdCiudadExpedicion)
                .HasConstraintName("FK_Prospecto_Ciudad1");

            entity.HasOne(d => d.IdCiudadResidenciaNavigation).WithMany(p => p.ProspectoIdCiudadResidenciaNavigations)
                .HasForeignKey(d => d.IdCiudadResidencia)
                .HasConstraintName("FK_Prospecto_Ciudad");

            entity.HasOne(d => d.IdCondicionDiscapacidadNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdCondicionDiscapacidad)
                .HasConstraintName("FK_Prospecto_CondicionDiscapacidad");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK_Prospecto_Estado");

            entity.HasOne(d => d.IdEstadoCivilNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdEstadoCivil)
                .HasConstraintName("FK_Prospecto_EstadoCivil");

            entity.HasOne(d => d.IdExperienciaLaboralNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdExperienciaLaboral)
                .HasConstraintName("FK_Prospecto_TiempoExperienciaLaboral");

            entity.HasOne(d => d.IdFuenteNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdFuente)
                .HasConstraintName("FK_Prospecto_FuenteAtencion");

            entity.HasOne(d => d.IdGrupoEtnicoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdGrupoEtnico)
                .HasConstraintName("FK_Prospecto_GrupoEtnico");

            entity.HasOne(d => d.IdIdentidadGeneroNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdIdentidadGenero)
                .HasConstraintName("FK_Prospecto_IdentidadGenero");

            entity.HasOne(d => d.IdLocalidadNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdLocalidad)
                .HasConstraintName("FK_Prospecto_Localidad");

            entity.HasOne(d => d.IdModoAtencionNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdModoAtencion)
                .HasConstraintName("FK_Prospecto_ModoAtencion");

            entity.HasOne(d => d.IdMotivoNoContinuarNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdMotivoNoContinuar)
                .HasConstraintName("FK_Prospecto_MotivoNoContinua");

            entity.HasOne(d => d.IdNacionalidadNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdNacionalidad)
                .HasConstraintName("FK_Prospecto_Nacionalidad");

            entity.HasOne(d => d.IdNumeroHijosNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdNumeroHijos)
                .HasConstraintName("FK_Prospecto_NumeroHijos");

            entity.HasOne(d => d.IdProfesionalRegistroNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdProfesionalRegistro)
                .HasConstraintName("FK_Prospecto_ProfesionalRegistro");

            entity.HasOne(d => d.IdSexoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdSexo)
                .HasConstraintName("FK_Prospecto_Sexo");

            entity.HasOne(d => d.IdSituacionActualNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdSituacionActual)
                .HasConstraintName("FK_Prospecto_SituacionActual");

            entity.HasOne(d => d.IdTiempoCesanteNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTiempoCesante)
                .HasConstraintName("FK_Prospecto_TiempoCesante");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoDocumento)
                .HasConstraintName("FK_Prospecto_TipoDocumento");

            entity.HasOne(d => d.IdTipoPermisoTrabajoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoPermisoTrabajo)
                .HasConstraintName("FK_Prospecto_TipoPermisoTrabajo");

            entity.HasOne(d => d.IdTipoPersonaCuidadoNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoPersonaCuidado)
                .HasConstraintName("FK_Prospecto_TipoPersonaCuidado");

            entity.HasOne(d => d.IdTipoPoblacionNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoPoblacion)
                .HasConstraintName("FK_Prospecto_TipoPoblacion");

            entity.HasOne(d => d.IdTipoRegistroNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoRegistro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Prospecto_TipoRegistro");

            entity.HasOne(d => d.IdTipoZonaNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdTipoZona)
                .HasConstraintName("FK_Prospecto_TipoZona");

            entity.HasOne(d => d.IdVehiculoPropioNavigation).WithMany(p => p.Prospectos)
                .HasForeignKey(d => d.IdVehiculoPropio)
                .HasConstraintName("FK_Prospecto_VehiculoPropio");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK_idRol");

            entity.ToTable("Rol", "aped");

            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.RolNombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstNavigation).WithMany(p => p.Rols)
                .HasForeignKey(d => d.IdEst)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_Estado");
        });

        modelBuilder.Entity<Sexo>(entity =>
        {
            entity.HasKey(e => e.IdSexo).HasName("PK_idSexo");

            entity.ToTable("Sexo", "aped");

            entity.Property(e => e.IdSexo).HasColumnName("idSexo");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.SexNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SituacionActual>(entity =>
        {
            entity.HasKey(e => e.IdSituacionActual).HasName("PK_idSituacionActual");

            entity.ToTable("SituacionActual", "aped");

            entity.Property(e => e.IdSituacionActual).HasColumnName("idSituacionActual");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.SitActNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiempoCesante>(entity =>
        {
            entity.HasKey(e => e.IdTiempoCesante).HasName("PK_idTiempoCesante");

            entity.ToTable("TiempoCesante", "aped");

            entity.Property(e => e.IdTiempoCesante).HasColumnName("idTiempoCesante");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TieCesNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TiempoExperienciaLaboral>(entity =>
        {
            entity.HasKey(e => e.IdTiempoExperienciaLaboral).HasName("PK_idTiempoExperienciaLaboral");

            entity.ToTable("TiempoExperienciaLaboral", "aped");

            entity.Property(e => e.IdTiempoExperienciaLaboral).HasColumnName("idTiempoExperienciaLaboral");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TieExpLabNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.HasKey(e => e.IdTipoDocumento).HasName("PK_idTipoDocumento");

            entity.ToTable("TipoDocumento", "aped");

            entity.Property(e => e.IdTipoDocumento).HasColumnName("idTipoDocumento");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipDocNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoLicencium>(entity =>
        {
            entity.HasKey(e => e.IdTipoLicencia).HasName("PK_idTipoLicencia");

            entity.ToTable("TipoLicencia", "aped");

            entity.Property(e => e.IdTipoLicencia).HasColumnName("idTipoLicencia");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipLicNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPermisoTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdTipoPermisoTrabajo).HasName("PK_idTipoPermisoTrabajo");

            entity.ToTable("TipoPermisoTrabajo", "aped");

            entity.Property(e => e.IdTipoPermisoTrabajo).HasColumnName("idTipoPermisoTrabajo");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipPerTraNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPersonaCuidado>(entity =>
        {
            entity.HasKey(e => e.IdTipoPersonaCuidado).HasName("PK_idTipoPersonaCuidado");

            entity.ToTable("TipoPersonaCuidado", "aped");

            entity.Property(e => e.IdTipoPersonaCuidado).HasColumnName("idTipoPersonaCuidado");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipPerCuiNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoPoblacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoPoblacion).HasName("PK_idTipoPoblacion");

            entity.ToTable("TipoPoblacion", "aped");

            entity.Property(e => e.IdTipoPoblacion).HasColumnName("idTipoPoblacion");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipPobNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoRegistro>(entity =>
        {
            entity.HasKey(e => e.IdTipoRegistro).HasName("PK_idTipoRegistro");

            entity.ToTable("TipoRegistro", "aped");

            entity.Property(e => e.IdTipoRegistro).HasColumnName("idTipoRegistro");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipRegNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoZona>(entity =>
        {
            entity.HasKey(e => e.IdTipoZona).HasName("PK_idTipoZona");

            entity.ToTable("TipoZona", "aped");

            entity.Property(e => e.IdTipoZona).HasColumnName("idTipoZona");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.TipZonNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK_idUsuario");

            entity.ToTable("Usuario", "aped");

            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.EstCorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Est_CorreoElectronico");
            entity.Property(e => e.IdEstado).HasColumnName("idEstado");
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.ProContrasena)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProFechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.ProFechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ProNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProUsuarioApp)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProUsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProUsuarioModificacion)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Estado");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Rol");
        });

        modelBuilder.Entity<VehiculoPropio>(entity =>
        {
            entity.HasKey(e => e.IdVehiculoPropio).HasName("PK_idVehiculoPropio");

            entity.ToTable("VehiculoPropio", "aped");

            entity.Property(e => e.IdVehiculoPropio).HasColumnName("idVehiculoPropio");
            entity.Property(e => e.IdEst).HasColumnName("idEst");
            entity.Property(e => e.VehProNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
