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
            //Auth: Hamza Advert
            CreateMap<Advert, AdvertDto>()
                .ForMember(adto => adto.Realtor, opt => opt.MapFrom(a => a.Realtor))
                .ForMember(adto => adto.Residence, opt => opt.MapFrom(a => a.Residence))
                .ReverseMap();

            //Auth: Hamza realtor to summary
            CreateMap<Realtor, RealtorSummaryDto>()
                .ForMember(rdto => rdto.AgencyName, opt => opt.MapFrom(r => r.Agency.Name))
                .ReverseMap();

            //Auth: Hamza Residence
            CreateMap<Residence, ResidenceDto>()
                .ForMember(rdto => rdto.Address, opt => opt.MapFrom(r => r.Address))
                .ReverseMap();

            //Auth: Hamza Realtor
            CreateMap<Realtor, RealtorDto>()
                .ForMember(rdto => rdto.ActiveAdverts, opt => opt.MapFrom(r => r.ActiveAdverts))
                .ReverseMap();

            // Viktor
            CreateMap<Realtor, RealtorImageDto>();

            // Realtor-profile by Robert
            CreateMap<Realtor, RealtorProfileDto>()
                .ForMember(rdto => rdto.AgencyName, opt => opt.MapFrom(r => r.Agency.Name));

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
            .ForMember(dest => dest.Rooms, opt => opt.MapFrom(src => src.Residence.Rooms))
            .ForMember(dest => dest.ImageUrls, opt => opt.MapFrom(src => src.Residence.ImageUrls ?? Array.Empty<string>())); // Samuel

            // Address : Samuel
            CreateMap<Address, AddressDto>()
                .ForMember(adto => adto.Residence, opt => opt.MapFrom(a => a.Residence))
                .ForMember(adto => adto.CommunName, opt => opt.MapFrom(a => a.Commun.Name))
                .ReverseMap();
            
            // Agency : Auth: Oscar
            CreateMap<Agency, AgencyWithSimpleRealtorsDto>()
                .ForMember(dest => dest.Realtors, opt => opt.MapFrom(src => src.Realtors));
            //Auth: Oscar
            CreateMap<Realtor, SimpleRealtorDto>()
                .ForMember(dest => dest.ActiveAdverts, opt => opt.MapFrom(src => src.ActiveAdverts));
            //Auth: Oscar
            CreateMap<CreateResidenceDto, Residence>()
                .Include<CreateResidenceDto, Apartment>()
                .Include<CreateResidenceDto, House>()
                .Include<CreateResidenceDto, RowHouse>()
                .Include<CreateResidenceDto, VacationHouse>()
                .ForMember(dest => dest.Address, opt => opt.Ignore())
                .ForMember(dest => dest.Advert, opt => opt.Ignore());
            //Auth: Oscar
            CreateMap<UpdateResidenceDto, Residence>()
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            //Agency-Agency by Jonathan
            CreateMap<AgencyCreateDto, Agency>()
                .ForMember(dest => dest.Address, opt => opt.Ignore());            

            // Auth: Samuel Change: Robert
            CreateMap<Address, AddressSummaryDto>()
                .ForMember(dest => dest.CommunName, opt => opt.MapFrom(src => src.Commun.Name));

            //Auth: Hamza Default mapping with no reference to any other class

            CreateMap<Residence, ResidenceSummaryDto>();
            CreateMap<Advert, AdvertSummaryDto>();
            CreateMap<Address, AddressDto>();            
            
            CreateMap<Realtor, SimpleRealtorDto>(); // Oscar
            CreateMap<Agency, AgencyWithRealtorsDto>(); // Oscar 
            CreateMap<UpdateRealtorProfileDto, Realtor>().ReverseMap(); // Jonathan
            CreateMap<AddressCreateDto, Address>(); //Jonathan
            CreateMap<CreateResidenceDto, Apartment>(); //Oscar
            CreateMap<CreateResidenceDto, House>(); //Oscar
            CreateMap<CreateResidenceDto, RowHouse>(); //Oscar
            CreateMap<CreateResidenceDto, VacationHouse>(); //Oscar
            CreateMap<Agency, AgencyDto>(); //Jonathan

            
        }
    }
}
