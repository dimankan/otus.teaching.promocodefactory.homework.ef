using AutoMapper;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Services.Contracts;
using Otus.Teaching.PromoCodeFactory.Services.Models.Preference;

namespace Otus.Teaching.PromoCodeFactory.Services.Services
{
    public class PreferenceService : IPreferenceService
    {
        private readonly IMapper _mapper;
        private readonly IPreferenceRepository _preferenceRepository;

        public PreferenceService(IMapper mapper, IPreferenceRepository preferenceRepository)
        {
            _mapper = mapper;
            _preferenceRepository = preferenceRepository;
        }

        public async Task<List<PreferenceDTO>> GetAllAsync()
        {
            return _mapper.Map<List<PreferenceDTO>>(await _preferenceRepository.GetAllAsync());
        }
    }
}
