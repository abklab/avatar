using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public partial class AddressVM
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string TimeAtAddress { get; set; }
        public string Telephone { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
