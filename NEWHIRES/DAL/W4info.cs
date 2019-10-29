using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class W4Info
    {
        public int EntryID { get; set; }
        public int AppID { get; set; }
        public string Filing { get; set; }
        public string LastNameDifferent { get; set; }
        public int? Allowances { get; set; }
        public decimal? AdditionalAmt { get; set; }
        public string WithholdExempt { get; set; }
        public string EmpSignature { get; set; }
        public string EmpSignDate { get; set; }
    }
}
