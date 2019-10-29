using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class TrainingResultsDetails
    {
        public int DetailsID { get; set; }
        public int AppID { get; set; }
        public int? CourseID { get; set; }
        public int? QuestID { get; set; }
        public string Answer { get; set; }
    }
}
