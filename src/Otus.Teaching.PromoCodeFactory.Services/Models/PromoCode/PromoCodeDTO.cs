using Otus.Teaching.PromoCodeFactory.Services.Models.Customer;
using Otus.Teaching.PromoCodeFactory.Services.Models.Preference;

namespace Otus.Teaching.PromoCodeFactory.Services.Models.PromoCode
{
    public class PromoCodeDTO
    {
        public string Code { get; set; }


        public Guid CustomerId { get; set; }

        public virtual CustomerDTO Customer { get; set; }


        public Guid PreferenceId { get; set; }

        public virtual PreferenceDTO Preference { get; set; }
    }
}
