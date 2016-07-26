using System;
using System.Collections.Generic;

namespace EntityTry.ORM.Models
{
    public partial class Contact
    {
        public int ContactID { get; set; }
        public string ContactType { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public string PhotoPath { get; set; }
        public byte[] Photo { get; set; }
    }
}
