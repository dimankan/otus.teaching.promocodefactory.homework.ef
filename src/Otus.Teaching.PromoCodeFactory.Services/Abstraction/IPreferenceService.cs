using Otus.Teaching.PromoCodeFactory.Services.Models.Preference;

namespace Otus.Teaching.PromoCodeFactory.Services.Contracts
{
    public interface IPreferenceService
    {
        Task<List<PreferenceDTO>> GetAllAsync();
    }
}
