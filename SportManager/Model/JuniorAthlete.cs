using SportManager.Model.Sports;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model
{
    class JuniorAthlete : Athlete
    {

        public string ParentName { get; set; }
        public JuniorAthlete(string id, string name, string surname, Gender gender, DateTime subscriptionDate, int age, double height, double weight, string parentName, Sport sport)
            : base(id, name, surname, gender, subscriptionDate, age, height, weight, sport)
        {
            ParentName = parentName;
        }
        public JuniorAthlete(string name, string surname, int age, Gender gender, string parentName) : base(name, surname, age, gender)
        {
            ParentName = parentName;
        }
        public override string getStipendio()
        {
            return "pagatemelo in caramelle!!";
        }

        public override string ToString()
        {
            string baseString = base.ToString();

            return baseString + "Nome Genitore: " + ParentName + "\n";
        }
    }
}
