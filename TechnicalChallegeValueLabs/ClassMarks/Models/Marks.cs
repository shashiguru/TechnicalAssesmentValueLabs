using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMarks.Models
{
   public class SubjectMarks
    {
        public double Math1 { get; set; }
        public double His { get; set; }
        public double Geo { get; set; }
        public double Eng { get; set; }
    }

    public class ClassesMarks
    {

        public SubjectMarks Class7 { get; set; }
        public SubjectMarks Class8 { get; set; }
        public SubjectMarks Class9 { get; set; }
        public SubjectMarks Class10 { get; set; }
        public SubjectMarks ClassN { get; set; }
    }
}
