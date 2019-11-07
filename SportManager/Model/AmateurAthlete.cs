using SportManager.Model;
using System;

namespace SportManager.Model
{
    internal class AmateurAthlete : Athlete
    {

        public AmateurAthlete(string id, string name, string surname, Gender gender, DateTime subscriptionDate, int age, double height, double weight)
            :base(id, name, surname, gender,subscriptionDate, age, height, weight ) { }
        public AmateurAthlete(string name, string surname, int age, Gender gender) : base(name, surname, age, gender) { }

        public override string getStipendio()
        {
            return "pago la retta!!";
        }

    }
}