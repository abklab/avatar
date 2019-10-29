using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I_9_Section_1
    {
        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string OtherLastName { get; set; }
        public string Nationality { get; set; }
        public string Res_DocumentType { get; set; }
        public string Res_DocumentNumber_3 { get; set; }
        public string Res_DocumentExpiration { get; set; }
        public string Res_AdmissionDoc { get; set; }
        public string CountryOfIssuance { get; set; }
        public string eSignature { get; set; }
        public string SignatureDate { get; set; }
        public string Self_Prepared { get; set; }
        public string PreparerLastName { get; set; }
        public string PreparerFirstname { get; set; }
        public string PreparerAddress { get; set; }
        public string PreparerCity { get; set; }
        public string PreparerState { get; set; }
        public string PreparerZip { get; set; }
        public string PrepareSignature { get; set; }
        public string PreparerSignatureDate { get; set; }

        public virtual ApplicationInfo App { get; set; }
    }
}
