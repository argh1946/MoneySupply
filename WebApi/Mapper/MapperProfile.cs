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
            CreateMap<MoneyType, MoneyTypeVM>().ReverseMap();
            CreateMap<Status, StatusVM>().ReverseMap();
            CreateMap<Request, RequestMoneySupplyVM>().ReverseMap();
        }
    }
}
