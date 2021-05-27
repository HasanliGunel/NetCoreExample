using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Database
{
    public class Subjects
    {
        public int ID { get; set; }
        public string StudentID { get; set; }
        public string Logic { get; set; }
        public string Informatics { get; set; }
        public string English { get; set; }
        public Student Student { get; set; } 
    }
}
