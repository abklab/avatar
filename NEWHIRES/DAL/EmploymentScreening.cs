using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class EmploymentScreening
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string FelonyOrMisdemeanor { get; set; }
        public string FelonyOrMisdemeanorDesc { get; set; }
        public string eSSignature { get; set; }
        public string SignatureDate { get; set; }
        public string OtherLastName { get; set; }
        public int? ScreenerID { get; set; }

        public virtual ApplicationInfo App { get; set; }
    }
}
