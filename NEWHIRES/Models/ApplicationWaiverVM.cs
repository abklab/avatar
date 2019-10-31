using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public  class ApplicationWaiverVM
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string ContactPrevEmployer { get; set; }
        public string Self_CompletedApp { get; set; }
        public string AppCompletedBy { get; set; }
        public string AppWaiverSignature { get; set; }
        public string AppWaiverSignDate { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
