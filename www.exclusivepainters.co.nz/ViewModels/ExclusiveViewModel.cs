using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.ViewModels
{
    public class ExclusiveViewModel
    {
        public IEnumerable<RegistrationForm> RegistrationForms { get; set; }

        public IEnumerable<UserAddress> UserAddresses { get; set; }
    }
}