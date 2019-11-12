using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;
using SportManager.Model.Sports;

namespace SportManager
{
    class DummyPersistenceLayer : IPersistence //implementiamo l interfaccia
    {
        public Athlete[] AllAthlete { get; set; } //creazioe property da inserire in un array di tipo Athlete (atleti dentro sacco di atleti)

        public DummyPersistenceLayer() //simulazione creaz. database
        {
            Sport calcio = new Soccer();
            Sport tennis = new Tennis();
            Sport pallavolo = new VolleyBall();

            Athlete a1 = new AmateurAthlete("mario", "rossi", 20, Gender.Male);
            a1.Age = -19;
            a1.Sport = calcio;


            Athlete a2 = new AmateurAthlete("GG01371347019", "Giorgio", "Gori", Gender.Male, DateTime.Now, 25, 1.82, 89, pallavolo);


            ProAthlete pa1 = new ProAthlete("Lebron", "James", 34, Gender.Male, "Nike");
            pa1.Height = 2.03;
            pa1.Weight = 113;
            pa1.Sport = tennis;

            Athlete pa2 = new ProAthlete("James", "Harden", 30, Gender.Male, "Adidas");



            pa2.Sport = tennis;






            Athlete aa1 = new AmateurAthlete("Giorgia", "Piccolini", 53, Gender.Female);

            aa1.Sport = pallavolo;



            JuniorAthlete ja1 = new JuniorAthlete("Carmelino", "James", 4, Gender.Male, "Pino James");
            ja1.Sport = calcio;


            Athlete ja2 = new JuniorAthlete("Guendalina", "Harden", 13, Gender.Female, "Anna Harden");
            ja2.Sport = tennis;

            AllAthlete = new Athlete[] { a1, a2, pa1, pa2, aa1, ja1, ja2 }; //inser. elementi creati sopra
        }

        public void SaveAthlete(Athlete a)
        {
            throw new NotImplementedException();
        }
    }
}
