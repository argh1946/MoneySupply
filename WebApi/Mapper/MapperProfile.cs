using AutoMapper;
using Core.DTOs;
using Core.Entities;

namespace React.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AtmCrs, AtmCrsVM>().ReverseMap();
        }
    }
}
