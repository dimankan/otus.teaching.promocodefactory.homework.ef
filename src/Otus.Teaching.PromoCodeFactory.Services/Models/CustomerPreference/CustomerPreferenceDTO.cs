﻿namespace Otus.Teaching.PromoCodeFactory.Services.Models.CustomerPreference
{
    public class CustomerPreferenceDTO
    {
        public Guid CustomerId { get; set; }

        public string CustomerName { get; set; }

        public Guid PreferenceId { get; set; }

        public string PreferenceName { get; set; }
    }
}
