using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class ApplicationInfo
    {
        public ApplicationInfo()
        {
            Address = new HashSet<Address>();
            ApplicationWaiver = new HashSet<ApplicationWaiver>();
            BackgroundInfo = new HashSet<BackgroundInfo>();
            DirectDeposit = new HashSet<DirectDeposit>();
            DriversLicense = new HashSet<DriversLicense>();
            EmergencyContacts = new HashSet<EmergencyContacts>();
            EmploymentRecord = new HashSet<EmploymentRecord>();
            EmploymentScreening = new HashSet<EmploymentScreening>();
            I_9_Section_1 = new HashSet<I_9_Section_1>();
            PreviousEmployer = new HashSet<PreviousEmployer>();
        }

        public int AppID { get; set; }
        public DateTime? AppDate { get; set; }
        public string AppType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string SSN { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? AppStatus { get; set; }

        public virtual DOT DOT { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<ApplicationWaiver> ApplicationWaiver { get; set; }
        public virtual ICollection<BackgroundInfo> BackgroundInfo { get; set; }
        public virtual ICollection<DirectDeposit> DirectDeposit { get; set; }
        public virtual ICollection<DriversLicense> DriversLicense { get; set; }
        public virtual ICollection<EmergencyContacts> EmergencyContacts { get; set; }
        public virtual ICollection<EmploymentRecord> EmploymentRecord { get; set; }
        public virtual ICollection<EmploymentScreening> EmploymentScreening { get; set; }
        public virtual ICollection<I_9_Section_1> I_9_Section_1 { get; set; }
        public virtual ICollection<PreviousEmployer> PreviousEmployer { get; set; }
    }
}
