using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class I_9_Documents
    {
        public int ID { get; set; }
        public int? AppID { get; set; }
        public byte[] DocData { get; set; }
        public int? Section2ID { get; set; }

        public virtual I_9_Section_2 Section2 { get; set; }
    }
}
