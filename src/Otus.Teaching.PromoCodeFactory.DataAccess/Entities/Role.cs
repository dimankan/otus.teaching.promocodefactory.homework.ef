using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Entities
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
