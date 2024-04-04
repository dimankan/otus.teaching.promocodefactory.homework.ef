using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using System;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Entities
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName => $"{FirstName} {LastName}";

        public string Email { get; set; }

        //TODO: Списки Preferences и Promocodes 
    }
}
