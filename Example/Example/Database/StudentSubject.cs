using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Database
{
    public class StudentSubject
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        
    }
}
