using System;
using System.Collections.Generic;

namespace NEWHIRES.Models
{
    public partial class TrainingResultsSummary
    {
        public int SummaryID { get; set; }
        public int CourseID { get; set; }
        public int AppID { get; set; }
        public int NumCorrect { get; set; }
        public int TotalQuestions { get; set; }
        public string Acknowledge { get; set; }
        public string TrainDate { get; set; }
    }
}
