using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class Employer
    {
        public int EmployerID { get; set; }
        public string EmployerName { get; set; }
        public string PhoneNumbers { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Contact_Name { get; set; }
        public string Contact_Position { get; set; }
        public string Contact_Phone { get; set; }
    }
}
