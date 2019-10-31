using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NEWHIRES.Models
{
    public class ApplicationInfoVM
    {
        [ScaffoldColumn(false)]
        public int AppID { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? AppDate { get; set; }
        public string AppType { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string MaidenName { get; set; }
        public string SSN { get; set; }
        public DateTime? DateOfBirth { get; set; }
        [ScaffoldColumn(false)]
        public int? AppStatus { get; set; }
      
    }
}
