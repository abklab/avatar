using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public  class DriversLicenseVM
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string DL_Number { get; set; }
        public string DL_State { get; set; }
        public DateTime? DL_Expiration { get; set; }
        public string DL_Type { get; set; }
        public string HasValid_DL { get; set; }
        public string NoDL_Acknowledged { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
