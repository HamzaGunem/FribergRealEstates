using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Data.AutoMapper
{
    //Auth: Hamza
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            //Advert
            CreateMap<Advert, AdvertDto>()
                .ForMember(adto => adto.Realtor, opt => opt.MapFrom(a => a.Realtor))
                .ForMember(adto => adto.Realtor, opt => opt.MapFrom(a => a.Residence))
                .ReverseMap();

            //Residence
            CreateMap<Residence, ResidenceDto>()
                .ForMember(rdto => rdto.Address, opt => opt.MapFrom(r => r.Address))
                .ReverseMap();

            CreateMap<Realtor, RealtorDto>()
                .ForMember(rdto => rdto.ActiveAdverts, opt => opt.MapFrom(r => r.ActiveAdverts))
                .ReverseMap();

            //Default mapping with no reference to any other class
            CreateMap<Realtor, RealtorSummaryDto>();
            CreateMap<Residence, ResidenceSummaryDto>();
            CreateMap<Advert, AdvertSummaryDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}
