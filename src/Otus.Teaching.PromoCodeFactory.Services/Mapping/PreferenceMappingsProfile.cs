using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using Otus.Teaching.PromoCodeFactory.Services.Models.Preference;

namespace Otus.Teaching.PromoCodeFactory.Services.Mapping
{
    public class PreferenceMappingsProfile : Profile
    {
        public PreferenceMappingsProfile()
        {
            CreateMap<Preference, PreferenceDTO>();
        }
    }

}
