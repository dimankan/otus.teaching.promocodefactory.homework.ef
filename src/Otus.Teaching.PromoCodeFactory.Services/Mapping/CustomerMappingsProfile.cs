using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using Otus.Teaching.PromoCodeFactory.Services.Models.Customer;

namespace Otus.Teaching.PromoCodeFactory.Services.Mapping
{
    public class CustomerMappingsProfile : Profile
    {
        public CustomerMappingsProfile()
        {
            CreateMap<Customer, CustomerDTO>();

            CreateMap<CreatingCustomerDTO, Customer>()
                .ForMember(d => d.Id, map => map.Ignore())
                .ForMember(d => d.PromoCodes, map => map.Ignore())
                .ForMember(d => d.CustomerPreferences, map => map.Ignore());

            CreateMap<UpdatingCustomerDTO, Customer>()
                .ForMember(d => d.Id, map => map.Ignore())
                .ForMember(d => d.PromoCodes, map => map.Ignore())
                .ForMember(d => d.CustomerPreferences, map => map.Ignore());
        }
    }
}
