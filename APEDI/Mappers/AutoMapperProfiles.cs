using AccesoDatos.Models;
using APEDI.Models;
using AutoMapper;
using Dominio.ModelosDominio;

namespace APEDI.Mappers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<ProspectoDTO, ProspectoModel>().
                ForMember(dest=> dest.Ciudad, opt=> opt.MapFrom(src=> src.CiuNombre)).
                ForMember(dest=> dest.CiudadNacimiento, opt=> opt.MapFrom(src=> src.NombreCodigoEvento));


            CreateMap<BasePoliticaPublica, BasePoliticaPublicaModel>().
                ForMember(dest => dest.id, opt => opt.MapFrom(src => src.IdBasePoliticaPublica)).
                ForMember(dest => dest.nombrePolitica, opt => opt.MapFrom(src => src.BasPolPubNombre)).
                ForMember(dest => dest.estado, opt => opt.MapFrom(src => src.IdEst));
        }
    }
}
