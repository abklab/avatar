using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class TrainingCourses
    {
        public TrainingCourses()
        {
            TrainingQuestions = new HashSet<TrainingQuestions>();
        }

        public int CourseID { get; set; }
        public string CourseDescription { get; set; }
        public bool IsActive { get; set; }
        public int? CourseOrder { get; set; }

        public virtual ICollection<TrainingQuestions> TrainingQuestions { get; set; }
    }
}
