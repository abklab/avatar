using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class DOT
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string PrevEmployers4DOT { get; set; }
        public string NoDOT_Past2Yrs { get; set; }
        public bool? DOT_Positive_Refusal { get; set; }
        public string eSignature { get; set; }
        public DateTime? Date { get; set; }

        public virtual ApplicationInfo Entry { get; set; }
    }
}
