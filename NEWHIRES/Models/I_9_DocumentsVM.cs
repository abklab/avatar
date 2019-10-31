using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public partial class I_9_DocumentsVM
    {
        public int ID { get; set; }
        public int? AppID { get; set; }
        public byte[] DocData { get; set; }
        public int? Section2ID { get; set; }

        public virtual I_9_Section_2VM Section2 { get; set; }
    }
}
