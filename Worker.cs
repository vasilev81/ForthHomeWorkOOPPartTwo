
namespace ExserciseTwo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Worker : Human
    {
        const int WorkingDays = 5;

        private decimal weekSalary;
        private int workHoursPerDay;
        private decimal moneyPerHour;
        public Worker (string firstName, string lastName) : base(firstName,lastName)
        {
            this.WeekSalary = default(int);
            this.WorkHoursPerDay = default(int);
        }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay {get;set;}

        public decimal ReturnMoneyPerHour
        {
            get
            {
                return this.moneyPerHour;
            }
            private set
            {
                this.moneyPerHour = value;
            }
        }
        public decimal MoneyPerHour(int WorkHoursPerDay, decimal WeekSalary)
        {
            this.ReturnMoneyPerHour = (WeekSalary / WorkingDays) / WorkHoursPerDay;

            return ReturnMoneyPerHour;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + " " + "MoneyPerHour:" + this.moneyPerHour;
        }
    }
}
