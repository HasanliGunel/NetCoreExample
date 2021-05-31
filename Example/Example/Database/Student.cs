using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Database
{
    public class Student
    {
        public Student()
        {
            StudentSubjects = new List<StudentSubject>();
        }
        public int ID { get; set; }
        public string LastName  { get; set; }
        public string FirstName { get; set; }
        public List<StudentSubject> StudentSubjects { get; set; }


    }
}
