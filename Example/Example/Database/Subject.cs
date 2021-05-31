using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Database
{
    public class Subject
    {
        public Subject()
        {
            StudentSubjects = new List<StudentSubject>();
        }
        public int ID { get; set; }
        public string Logic { get; set; }
        public string Informatics { get; set; }
        public string English { get; set; }
        public List<StudentSubject>StudentSubjects { get; set; }
        
    }
}
