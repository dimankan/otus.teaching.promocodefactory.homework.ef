using System;
using System.Runtime;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;

namespace Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement
{
    public class PromoCode
        : BaseEntity
    {
        public string Code { get; set; }

        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public Guid PreferenceId { get; set; }

        public virtual Preference Preference { get; set; }
    }
}