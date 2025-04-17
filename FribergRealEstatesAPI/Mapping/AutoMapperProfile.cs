using AutoMapper;
using FribergRealEstatesAPI.Data.Dto;
using FribergRealEstatesAPI.Models;

namespace FribergRealEstatesAPI.Mapping
{
    //Auth: Hamza
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Advert
            CreateMap<Advert, AdvertDto>()
                .ForMember(adto => adto.Realtor, opt => opt.MapFrom(a => a.Realtor))
                .ForMember(adto => adto.Residence, opt => opt.MapFrom(a => a.Residence))
                .ReverseMap();

            //Residence
            CreateMap<Residence, ResidenceDto>()
                .ForMember(rdto => rdto.Address, opt => opt.MapFrom(r => r.Address))
                .ReverseMap();

            //Realtor
            CreateMap<Realtor, RealtorDto>()
                .ForMember(rdto => rdto.ActiveAdverts, opt => opt.MapFrom(r => r.ActiveAdverts))
                .ReverseMap();

          // Realtor-Adverts by Robert
            CreateMap<Advert, RealtorAdvertsDto>()
            .ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
            .ForMember(dest => dest.Sold, opt => opt.MapFrom(src => src.Sold))
            .ForMember(dest => dest.CurrentPrice, opt => opt.MapFrom(src => src.CurrentPrice))
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Realtor.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Realtor.LastName))
            .ForMember(dest => dest.Agency, opt => opt.MapFrom(src => src.Realtor.Agency.Name))
            .ForMember(dest => dest.Street, opt => opt.MapFrom(src => src.Residence.Address.Street))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.Residence.Address.City))
            .ForMember(dest => dest.Commune, opt => opt.MapFrom(src => src.Residence.Address.Commun.Name))
            .ForMember(dest => dest.Area, opt => opt.MapFrom(src => src.Residence.Area))
            .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Residence.Rooms));

            // Address : Samuel
            CreateMap<Address, AddressDto>()
                .ForMember(adto => adto.Residence, opt => opt.MapFrom(a => a.Residence))
                .ForMember(adto => adto.CommunName, opt => opt.MapFrom(a => a.Commun.Name))
                .ReverseMap();


            //Default mapping with no reference to any other class
            CreateMap<Realtor, RealtorSummaryDto>();
            CreateMap<Residence, ResidenceSummaryDto>();
            CreateMap<Advert, AdvertSummaryDto>();
            CreateMap<Address, AddressDto>();
            CreateMap<Address, AddressSummaryDto>(); // Samuel
        }
    }
}
