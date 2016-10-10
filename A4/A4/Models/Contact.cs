using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A4.Models
{
    public class Contact
    {
        public int contactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string StreetAddress { get; set; }

        public string City { get; set; }
        public int ZipCode { get; set; }

    }
}