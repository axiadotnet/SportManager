using SportManager.Model;
using SportManager.Model.Sports;
using System;

namespace SportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyPersistenceLayer persistence = new DummyPersistenceLayer();
            //DataBasePersistenceLayer persistence = new DataBasePersistenceLayer();
            LogicLayer logic = new LogicLayer(persistence);

            UserInterfaceLayer gui = new UserInterfaceLayer(logic);
            gui.start();
            //Sport calcio = new Soccer();
            //Sport tennis = new Tennis();
            //Sport pallavolo = new VolleyBall();

            //Athlete a1 = new AmateurAthlete("mario", "rossi", 20, Gender.Male);
            //a1.Age = -19;
            //a1.Sport = calcio;


            //Athlete a2 = new AmateurAthlete("GG01371347019", "Giorgio", "Gori", Gender.Male, DateTime.Now, 25, 1.82, 89, pallavolo);
            //Console.WriteLine(a2);

            //ProAthlete pa1 = new ProAthlete("Lebron", "James", 34, Gender.Male, "Nike");
            //pa1.Height = 2.03;
            //pa1.Weight = 113;
            //pa1.Sport = tennis;

            //pa1.Sponsor = "Puma";

            //Athlete pa2 = new ProAthlete("James", "Harden", 30, Gender.Male, "Adidas");

            ////pa2.Sponsor = "Puma"; non si può!!ù

            //pa2.Sport = tennis;

            //Console.WriteLine(pa1);




            //Athlete aa1 = new AmateurAthlete("Giorgia","Piccolini",53, Gender.Female);

            //aa1.Sport = pallavolo;



            //JuniorAthlete ja1 = new JuniorAthlete("Carmelino", "James", 4, Gender.Male, "Pino James");
            //ja1.Sport = calcio;


            //Athlete ja2 = new JuniorAthlete("Guendalina", "Harden", 13, Gender.Female, "Anna Harden");
            //ja2.Sport = tennis;

            //Athlete[] team = { a1, a2, pa1, pa2, aa1, ja1, ja2};

            //Athlete a5 = team[2];

            //ProAthlete p5 = (ProAthlete)team[2];


            //ProAthlete[] teamPro = { pa1, (ProAthlete)pa2 };

            //ProAthlete p6 = teamPro[1];

            //Athlete a6 = teamPro[1];


            //foreach (Athlete athlete in team)
            //{
            //    Console.WriteLine(athlete.getStipendio());
            //}

            //for (int i = 0; i < team.Length; i++)
            //{
            //    Console.WriteLine(team[i]);
            //}


            //Athlete c1 = new AmateurAthlete("Pino", "Pini", 30, Gender.Male);
            //Athlete c2 = new AmateurAthlete("Lino", "Pini", 30, Gender.Male);
            //Athlete c3 = new AmateurAthlete("Gino", "Pini", 30, Gender.Male);
            //Athlete c4 = new AmateurAthlete("Tino", "Pini", 30, Gender.Male);
            //Athlete c5 = new AmateurAthlete("Dino", "Pini", 30, Gender.Male);

            //Athlete[] squadra = { c1, c2, c3, c4, c5 };

            //Team eroica = new Team(squadra);
        }
    }
}
