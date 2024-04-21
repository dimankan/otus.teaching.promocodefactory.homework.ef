using Otus.Teaching.PromoCodeFactory.Services.Models.CustomerPreference;

namespace Otus.Teaching.PromoCodeFactory.Services.Models.Preference
{
    public class PreferenceDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public virtual List<CustomerPreferenceDTO> CustomerPreferences { get; set; }
    }
}
