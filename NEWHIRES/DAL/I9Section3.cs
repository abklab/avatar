using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I9Section3
    {
        public int EntryId { get; set; }
        public int? AppId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string RehireDate { get; set; }
        public string DocumentTitle { get; set; }
        public string DocumentNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string AuthorizedRepSignature { get; set; }
        public string AuthorizedRepSignDate { get; set; }
        public string AuthorizedRepLastName { get; set; }
    }
}
