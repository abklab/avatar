using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class TrainingDocumentation
    {
        public int EntryID { get; set; }
        public int AppID { get; set; }
        public byte[] ApplicantSignature { get; set; }
        public string AppSignatureDate { get; set; }
        public string Trainer { get; set; }
    }
}
