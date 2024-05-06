using Microsoft.EntityFrameworkCore;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class CustomerRepository : EfRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) : base(context)
        {
        }

        public override async Task<List<Customer>> GetAllAsync()
        {
            return await Context.Set<Customer>()
                .Include(r => r.CustomerPreferences)
                .ThenInclude(cp => cp.Preference)
                .ToListAsync();
        }

        public override async Task<Customer> GetByIdAsync(Guid id)
        {
            return await Context.Set<Customer>()
                .Include(r => r.CustomerPreferences)
                .ThenInclude(cp => cp.Preference)
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }


}
