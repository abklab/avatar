using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class JobSetup
    {
        public int JobID { get; set; }
        public string SetupDate { get; set; }
        public string JobNumber { get; set; }
        public string WorkState { get; set; }
        public string AppType { get; set; }
        public int? JobStatus { get; set; }
        public string Description { get; set; }
        public bool? IsDOT_required { get; set; }
        public string SetupBy { get; set; }
        public string AuditTrail { get; set; }
    }
}
