using SportManager.Model.Sports;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model
{
    internal class ProAthlete : Athlete
    {
        public string Sponsor { get; set; }

        public ProAthlete(string id, string name, string surname, Gender gender, DateTime subscriptionDate, int age, double height, double weight, string sponsor, Sport sport)
            : base(id, name, surname, gender, subscriptionDate, age, height, weight, sport) 
        {
            Sponsor = sponsor;
        }
        public ProAthlete(string name, string surname, int age, Gender gender, string sponsor):base(name, surname, age, gender)
        {
            Sponsor = sponsor;
        }

        public override string getStipendio()
        {
            return "1000000 di dollari";
        }

        public override string ToString()
        {
            string baseString = base.ToString();

            return baseString + "Sponsor: " + Sponsor + "\n";
        }
    }
}
