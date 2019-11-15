using SportManager.Model;
using SportManager.Model.Sports;
using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Exceptions;

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
            Console.WriteLine("Inserisci il nome");
            string name = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string surname = Console.ReadLine();
            Console.WriteLine("Inserisci l'età");
            int age = int.Parse(Console.ReadLine());
            Gender gender = Gender.Female;

            AmateurAthlete nuovoAtleta = new AmateurAthlete(name, surname, age, gender);

            nuovoAtleta.Sport = new Soccer();

            try
            {
                MyLogic.insertAthlete(nuovoAtleta);
            }
            catch (Exception)
            {

            }

        }

        private void searchAthlete()
        {
            Console.WriteLine("Inserisci il Nome della persona da cercare");
            string searchString = Console.ReadLine();
            try
            {
                Athlete searchedAthlete = MyLogic.searchAthlete(searchString);
                Console.WriteLine(searchedAthlete);
            }
            catch (AthleteNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            

            

            //Athlete searchedAthlete = MyLogic.searchAthlete(searchString);
            //if (searchedAthlete != null)
            //{
            //    Console.WriteLine(searchedAthlete);
            //}
            //else
            //{
            //    Console.WriteLine("Atleta non trovato");
            //}
        }

        private void showAthletesList()
        {
            IEnumerable<Athlete> athletesList = MyLogic.getAllAthletes();

            foreach (Athlete atl in athletesList)
            {
                Console.WriteLine(atl);
            }
        }


    }
}
