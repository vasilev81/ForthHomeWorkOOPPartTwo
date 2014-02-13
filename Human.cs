﻿
namespace ExserciseTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        
    }
}
