using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CRM.Models;

namespace CRM.ViewModels
{
    public class CustomerAddressViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public Address Addresses { get; set; }
    }
}