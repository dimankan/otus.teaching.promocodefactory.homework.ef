using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Services.Models.Customer;
using Otus.Teaching.PromoCodeFactory.WebHost.Models;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Map
{
    public class CustomerMappingsProfileForApi : Profile
    {
        public CustomerMappingsProfileForApi()
        {
            CreateMap<CustomerDTO, CustomerModel>();
            CreateMap<CreatingCustomerModel, CreatingCustomerDTO>();
            CreateMap<UpdatingCustomerModel, UpdatingCustomerDTO>();
        }
    }
   
}
