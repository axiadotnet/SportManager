using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model.Sports
{
    internal abstract class Sport
    {
        public string Name { get; }
        public decimal Salary { get; set; }

        protected Sport(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public string getSalaryString()
        {
            return Salary.ToString("C2");
        }

        public abstract int CalcDailyCalory(double bMi);
    }
}
