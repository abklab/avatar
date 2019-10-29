using System;
using System.Collections.Generic;

namespace NEWHIRES.DAL
{
    public partial class TrainingQuestions
    {
        public int QuestID { get; set; }
        public int CourseID { get; set; }
        public int? QuestionNum { get; set; }
        public bool? ActiveQuestion { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string Explanation { get; set; }

        public virtual TrainingCourses Course { get; set; }
    }
}
