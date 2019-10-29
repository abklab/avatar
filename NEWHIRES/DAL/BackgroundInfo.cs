using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class BackgroundInfo
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string HasFelonyMisdemeanor { get; set; }
        public string ExplainFelonyMisdemeanor { get; set; }
        public string ArmedForces { get; set; }
        public string AFBranch { get; set; }
        public string NationalGuard { get; set; }
        public string Specialty { get; set; }
        public string CompanyPrevEmployee { get; set; }
        public string CompanyPrevEmpDetails { get; set; }
        public string IsFirstEmployment { get; set; }
        public string HasSpecialLicense { get; set; }
        public string SpecialLicDetails { get; set; }

        public virtual ApplicationInfo App { get; set; }
    }
}
