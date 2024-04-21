using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.DataAccess.Data;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Repositories
{
    public class EFDataInitializer : IDataInitializer
    {
        protected readonly DatabaseContext Context;

        public EFDataInitializer(DatabaseContext context)
        {
            Context = context;
        }

        public void InitData()
        {
            Context.Database.EnsureDeleted();

            Context.Database.EnsureCreated();

            Context.AddRange(FakeDataFactory.Roles);
            Context.AddRange(FakeDataFactory.Employees);
            Context.AddRange(FakeDataFactory.Customers);
            Context.AddRange(FakeDataFactory.Preferences);
            Context.AddRange(FakeDataFactory.CustomerPreferences);
            Context.AddRange(FakeDataFactory.PromoCodes);

            Context.SaveChanges();
        }
    }


}
