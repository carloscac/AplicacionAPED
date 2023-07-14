using System;

namespace Dominio.ModelosDominio
{
    public class ProspectoDTO
    {
        public DateTime FechaRegistro { get; set; }
        public string NombreCodigoEvento { get; set; }
        public string OtroProfesional { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NombresCompleto { get; set; }
        public string NombreIdentatario { get; set; }
        public DateTime FechaExpedición { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int idTipoRegistro { get; set; }
        public string TipRegNombre { get; set; }
        public int idFuenteAtencion { get; set; }
        public string FueAteNombre { get; set; }
        public int idBasePoliticaPublica { get; set; }
        public string BasPolPubNombre { get; set; }

        public int idModoAtencion { get; set; }
        public string ModAteNombre { get; set; }

        public int idProfesionalRegistro { get; set; }
        public string ProRegNombre { get; set; }

        public int idTipoDocumento { get; set; }
        public string TipDocNombre { get; set; }

        public int idCiudad { get; set; }
        public string CiuNombre { get; set; }

        public int idSexo { get; set; }
        public string SexNombre { get; set; }
    }


}
