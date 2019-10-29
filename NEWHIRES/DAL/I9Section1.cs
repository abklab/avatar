using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I9Section1
    {
        public int EntryId { get; set; }
        public int? AppId { get; set; }
        public string OtherLastName { get; set; }
        public string Nationality { get; set; }
        public string ResDocumentType { get; set; }
        public string ResDocumentNumber3 { get; set; }
        public string ResDocumentExpiration { get; set; }
        public string ResAdmissionDoc { get; set; }
        public string CountryOfIssuance { get; set; }
        public string ESignature { get; set; }
        public string SignatureDate { get; set; }
        public string SelfPrepared { get; set; }
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
