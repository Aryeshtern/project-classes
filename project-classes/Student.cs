using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_classes
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, int averagegrades)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            AverageGrads = averagegrades;


        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AverageGrads { get; set; }
    }
}
