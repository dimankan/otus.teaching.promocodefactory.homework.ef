using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; }

        //public Role Role { get; set; }
        public Guid RoleId { get; set; }

        public int AppliedPromocodesCount { get; set; }
    }
}
