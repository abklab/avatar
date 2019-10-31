using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public class Pre_Emp_DrugTestVM
    {
        public int PID { get; set; }
        public int? AppID { get; set; }
        public string ApplicantSignature { get; set; }
        public string SignatureDate { get; set; }
        public string HasAgreed { get; set; }
        public string Witness { get; set; }
    }
}
