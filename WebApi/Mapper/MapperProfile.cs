using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.Helper;

namespace React.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AtmCrs, AtmCrsVM>().ReverseMap();
            CreateMap<FileType, FileTypeVM>().ReverseMap();
            CreateMap<MoneyType, MoneyTypeVM>().ReverseMap();
            CreateMap<Status, StatusVM>().ReverseMap();
            CreateMap<Request, RequestMoneySupplyVM>().ReverseMap();
            CreateMap<Request, RequestEfardaVM>().ReverseMap();
            CreateMap<RequestMoneySupplyInput, Request>()
                .ForMember(dest => dest.RequestDate, opt => opt.MapFrom(src => ConvertToDateTime.ToDateTime(src.RequestDate))).ReverseMap();

            CreateMap<Branch, BranchVM>().ReverseMap();
        }
    }
}
