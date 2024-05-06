using System;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Models
{
    public class EmployeeModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int AppliedPromocodesCount { get; set; }

        public Guid RoleId { get; set; }
    }
}
