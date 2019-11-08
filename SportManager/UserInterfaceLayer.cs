using SportManager.Model;
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

        public ILogic myLogic { get; set; }

        public UserInterfaceLayer(ILogic logic)
        {
            myLogic = logic;

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

        }

        private void searchAthlete()
        {

        }

        private void showAthletesList()
        {
            Athlete[] athletesArray = myLogic.getAllAthletes();

            foreach (Athlete atl in athletesArray)
            {
                Console.WriteLine(atl);
            }
        }
    }
}
