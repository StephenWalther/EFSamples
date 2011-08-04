using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFSamples.Areas.Sample1ComplexObjects.Models {
    public class Customer {

        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address BillingAddress { get; set; }

        public Address ShippingAddress { get; set; }
    }


    public class Address {
        public string Street { get; set; }
        public string City { get; set; }
    }


}