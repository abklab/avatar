using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I9Documents
    {
        public int Id { get; set; }
        public int? AppId { get; set; }
        public byte[] DocData { get; set; }
        public int? Section2Id { get; set; }

        public virtual I9Section2 Section2 { get; set; }
    }
}
