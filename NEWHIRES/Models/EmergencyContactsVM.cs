using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public  class EmergencyContactsVM
    {
        public int EntryID { get; set; }
        public int AppID { get; set; }
        public string Contact_Name { get; set; }
        public string Relationship { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Notes { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
