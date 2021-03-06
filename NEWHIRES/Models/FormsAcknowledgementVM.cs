﻿using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public  class FormsAcknowledgementVM
    {
        public int ID { get; set; }
        public int? AppID { get; set; }
        public int? FormID { get; set; }
        public string eSignature { get; set; }
        public DateTime? eSignatureDate { get; set; }
        public bool? FormStatus { get; set; }
    }
}
