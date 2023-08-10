﻿
using AccesoDatos.Models;
using Dominio.ModelosDominio;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositorio
{
    public class RepositorioAplicacion : IRepositorioAplicacion
    {
        private AplicacionesContext _contexto;

        public RepositorioAplicacion(AplicacionesContext contexto)
        {
            _contexto = contexto;
        }


        #region PROSPECTO

        public List<Prospecto> ListaProspectos()
        {
            List<Prospecto> listaProspectos = _contexto.Prospectos.ToList();

            return listaProspectos;
        }

        public void CrearProspecto(Prospecto prospecto)
        {
            _contexto.Prospectos.Add(prospecto);
            _contexto.SaveChanges();
        }

        public Prospecto ConsultaPorId(string idDocumento)
        {
            Prospecto prospecto = _contexto.Prospectos.Where(e => e.NumeroIdentificacion == idDocumento).FirstOrDefault();

    

            var consulta = _contexto.Database.SqlQueryRaw<ProspectoDTO>("PA_ConsutarProspectoPorIdentificacion @Identificacion",
                new SqlParameter("@Identificacion", idDocumento));


            return prospecto;
        }

        public Prospecto ActualizarProspecto(Prospecto prospecto)
        {
            Prospecto prospectoBD = _contexto.Prospectos.Where(e => e.IdProspecto == prospecto.IdProspecto).FirstOrDefault();

            prospectoBD.Barrio = prospecto.Barrio;
            prospectoBD.LibretaMilitar = prospecto.LibretaMilitar;
            prospectoBD.IdLocalidad = prospecto.IdLocalidad;


            _contexto.SaveChanges();
            return prospectoBD;

        }

        public void EliminarProspecto(int idProspecto)
        {
            Prospecto prospecto = _contexto.Prospectos.Where(e => e.IdProspecto == idProspecto).FirstOrDefault();
            prospecto.IdEstado = 0;
            //_contexto.Prospectos.Remove(prospecto);
            _contexto.SaveChanges();


        }

        #endregion

        #region Listas

        public List<BasePoliticaPublica> ListaBasePolitica()
        {
            return _contexto.BasePoliticaPublicas.Where(e => e.IdEst == 1).ToList();
        }

        public List<CategoriaLicencium> LisaCategoriaLicencia()
        {
            return _contexto.CategoriaLicencia.Where(e => e.IdEst == 1).ToList();
        }

        public List<CertificadoPoblacional> ListaCertificadoPoblacional()
        {
            return _contexto.CertificadoPoblacionals.Where(e => e.IdEst == 1).ToList();
        }

        public List<TipoRegistro> ListaTipoRegistro()
        {
            return _contexto.TipoRegistros.ToList();
        }

        public List<FuenteAtencion> ListaTipoFuente()
        {
            return _contexto.FuenteAtencions.Where(e=> e.IdEst == 1).ToList();
        }

        public List<ModoAtencion> ListaModoAtencion()
        {
            return _contexto.ModoAtencions.Where(e=> e.IdEst == 1).ToList();
        }

        #endregion


    }
}
