using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class PreEmpDrugTest
    {
        public int Pid { get; set; }
        public int? AppId { get; set; }
        public string ApplicantSignature { get; set; }
        public string SignatureDate { get; set; }
        public string HasAgreed { get; set; }
        public string Witness { get; set; }
    }
}
