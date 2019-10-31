using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public  class DirectDepositVM
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string Bank_1 { get; set; }
        public string RoutingNo_1 { get; set; }
        public string AcctNo_1 { get; set; }
        public string AcctType_1 { get; set; }
        public string Deposit_1 { get; set; }
        public string Bank_2 { get; set; }
        public string RoutingNo_2 { get; set; }
        public string AcctNo_2 { get; set; }
        public string AcctType_2 { get; set; }
        public string Deposit_2 { get; set; }
        public string EmpSignature { get; set; }
        public string EmpSignDate { get; set; }

        public virtual ApplicationInfoVM App { get; set; }
    }
}
