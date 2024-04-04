using AutoMapper;
using DomainAdmin = Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using DomainPromoCodeManagment = Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Entities.Employee, DomainAdmin.Employee>().ReverseMap();
            CreateMap<Entities.Role, DomainAdmin.Role>().ReverseMap();
            
            CreateMap<Entities.Customer, DomainPromoCodeManagment.Customer>().ReverseMap();
            CreateMap<Entities.Preference, DomainPromoCodeManagment.Preference>().ReverseMap();
        }
    }
}
