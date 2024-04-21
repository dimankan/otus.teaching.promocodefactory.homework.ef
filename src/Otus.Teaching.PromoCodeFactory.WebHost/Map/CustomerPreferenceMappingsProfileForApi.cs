using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Services.Models.CustomerPreference;
using Otus.Teaching.PromoCodeFactory.WebHost.Models;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Map
{
    public class CustomerPreferenceMappingsProfileForApi : Profile
    {
        public CustomerPreferenceMappingsProfileForApi()
        {
            CreateMap<CustomerPreferenceDTO, CustomerPreferenceModel>();
        }
    }
   
}
