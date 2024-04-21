using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class PreferenceRepository : EfRepository<Preference>, IPreferenceRepository
    {
        public PreferenceRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<Preference>> GetAllAsync()
        {
            return await Context.Set<Preference>()
                .Include(r => r.CustomerPreferences)
                .ThenInclude(cp => cp.Customer)
                .ToListAsync();
        }
    }
}
