using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public class I_9_Section_2VM
    {
        public I_9_Section_2VM()
        {
            I_9_Documents = new HashSet<I_9_DocumentsVM>();
        }

        public int EntryID { get; set; }
        public int? AppID { get; set; }
        public string Doc_List { get; set; }
        public string Doc_Title { get; set; }
        public string IssuingAuthority { get; set; }
        public string Doc_Number { get; set; }
        public DateTime? Doc_ExpirationDate { get; set; }
        public string AuthorizedRep_Title { get; set; }
        public string AuthorizedRep_LastName { get; set; }
        public string AuthorizedRep_FirstName { get; set; }
        public string AuthorizedRep_Signature { get; set; }
        public DateTime? AuthorizedRep_SignDate { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<I_9_DocumentsVM> I_9_Documents { get; set; }
    }
}
