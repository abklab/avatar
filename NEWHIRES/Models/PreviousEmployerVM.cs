using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public class PreviousEmployerVM
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string EmployerName { get; set; }
        public string BusinessAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Supervisor { get; set; }
        public string JobTitle { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string ReasonForLeaving { get; set; }
        public string JobDuties { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
