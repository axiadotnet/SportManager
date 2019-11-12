using SportManager.Model;
using SportManager.Model.Sports;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager
{
    class UserInterfaceLayer
    {
        const string INTRO = "Benvenuto in Sport Manager\n" +
            "scegli tra le opzioni:\n" +
            "'l' per la lista degli iscritti\n" +
            "'c' per cercare un iscritto\n" +
            "'i' per inserire un nuovo iscritto\n" +
            "'q' per uscire";

        public ILogic MyLogic { get; set; }

        public UserInterfaceLayer(ILogic logic)
        {
            MyLogic = logic;

        }


        public void start()
        {
            Console.WriteLine(INTRO);
            string rensponse = Console.ReadLine();

            switch (rensponse.ToLower())
            {
                case "l":
                    showAthletesList();
                    break;
                case "c":
                    searchAthlete();
                    break;
                case "i":
                    insertAthlete();
                    break;
                case "q":
                    return;
                default:
                    break;
            }
            start();
        }

        private void insertAthlete()
        {
            string name = "Lorena";
            string surname = "Schirru";
            int age = 35;
            Gender gender = Gender.Female;

            AmateurAthlete nuovoAtleta = new AmateurAthlete(name, surname, age, gender);

            nuovoAtleta.Sport = new Soccer();

            MyLogic.insertAthlete(nuovoAtleta);

        }

        private void searchAthlete()
        {

        }

        private void showAthletesList()
        {
            Athlete[] athletesArray = MyLogic.getAllAthletes();

            foreach (Athlete atl in athletesArray)
            {
                Console.WriteLine(atl);
            }
        }
    }
}
