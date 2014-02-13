
namespace ExserciseTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade) : base(firstName,lastName)
        {
            this.Grade = grade;
        }

        public int Grade { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + "grade:" + this.Grade;
        }
    }
}
