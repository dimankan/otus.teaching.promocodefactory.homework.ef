﻿using System.Collections.Generic;
using System;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Models
{
    public class CustomerModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        //public virtual List<PromoCodeModel> PromoCodes { get; set; }

        public virtual List<CustomerPreferenceModel> CustomerPreferences { get; set; }
    }
}
