using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I9Section2
    {
        public I9Section2()
        {
            I9Documents = new HashSet<I9Documents>();
        }

        public int EntryId { get; set; }
        public int? AppId { get; set; }
        public string DocList { get; set; }
        public string DocTitle { get; set; }
        public string IssuingAuthority { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DocExpirationDate { get; set; }
        public string AuthorizedRepTitle { get; set; }
        public string AuthorizedRepLastName { get; set; }
        public string AuthorizedRepFirstName { get; set; }
        public string AuthorizedRepSignature { get; set; }
        public DateTime? AuthorizedRepSignDate { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<I9Documents> I9Documents { get; set; }
    }
}
