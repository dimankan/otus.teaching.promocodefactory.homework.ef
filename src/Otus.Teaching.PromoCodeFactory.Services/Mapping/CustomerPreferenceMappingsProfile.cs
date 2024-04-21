using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using Otus.Teaching.PromoCodeFactory.Services.Models.CustomerPreference;

namespace Otus.Teaching.PromoCodeFactory.Services.Mapping
{
    public class CustomerPreferenceMappingsProfile : Profile
    {
        public CustomerPreferenceMappingsProfile()
        {
            CreateMap<CustomerPreference, CustomerPreferenceDTO>()
                .ForMember(d => d.CustomerName, map => map.MapFrom(m => m.Customer.LastName))
                .ForMember(d => d.PreferenceName, map => map.MapFrom(m => m.Preference.Name));
        }
    }

}
