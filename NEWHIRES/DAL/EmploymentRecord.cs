using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class EmploymentRecord
    {
        public int EntryID { get; set; }
        public int AppID { get; set; }
        public string Division { get; set; }
        public string PaycheckDelivery { get; set; }
        public string CheckDeliveryLocation { get; set; }
        public string CheckEmail { get; set; }
        public string HireDate { get; set; }
        public string Provide_EEO { get; set; }
        public string EEO_Gender { get; set; }
        public string EEO_Ethnicity { get; set; }
        public string Benefits_Medical { get; set; }
        public string Benefits_Dental { get; set; }
        public string Benefits_Supplemental { get; set; }
        public string Benefits_Life { get; set; }
        public string Benefits_401K { get; set; }
        public string JobLocal { get; set; }
        public string HomeLocal { get; set; }
        public string CardNumber { get; set; }
        public string Trade { get; set; }
        public string Classification { get; set; }
        public string ApprenticeYear { get; set; }
        public string ApprenticeRate { get; set; }
        public string OtherClassification { get; set; }
        public string IsReferralAttached { get; set; }

        public virtual ApplicationInfo App { get; set; }
    }
}
