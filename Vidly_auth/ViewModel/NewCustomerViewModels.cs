using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_auth.Models;

namespace Vidly_auth.ViewModel
{
    public class NewCustomerViewModels
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}