using SportManager.Model;
using System;

namespace SportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete a1 = new AmateurAthlete("mario", "rossi", 20, Gender.Male);
            a1.Age = -19;

            Athlete a2 = new AmateurAthlete("GG01371347019", "Giorgio", "Gori", Gender.Male, DateTime.Now, 25, 1.82, 89);
            Console.WriteLine(a2);

            ProAthlete pa1 = new ProAthlete("Lebron", "James", 34, Gender.Male, "Nike");
            pa1.Height = 2.03;
            pa1.Weight = 113;

            pa1.Sponsor = "Puma";

            Athlete pa2 = new ProAthlete("James", "Harden", 30, Gender.Male, "Adidas");

            //pa2.Sponsor = "Puma"; non si può!!

            Console.WriteLine(pa1);




            Athlete aa1 = new AmateurAthlete("Giorgia","Piccolini",53, Gender.Female);


            JuniorAthlete ja1 = new JuniorAthlete("Carmelino", "James", 4, Gender.Male, "Pino James");

            Athlete ja2 = new JuniorAthlete("Guendalina", "Harden", 13, Gender.Female, "Anna Harden");


            Athlete[] team = { a1, a2, pa1, pa2, aa1, ja1, ja2};

            Athlete a5 = team[2];

            ProAthlete p5 = (ProAthlete)team[2];


            ProAthlete[] teamPro = { pa1, (ProAthlete)pa2 };

            ProAthlete p6 = teamPro[1];

            Athlete a6 = teamPro[1];


            foreach (Athlete athlete in team)
            {
                Console.WriteLine(athlete.getStipendio());
            }

            for (int i = 0; i < team.Length; i++)
            {
                Console.WriteLine(team[i]);
            }
        }
    }
}
