using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;

namespace SportManager
{
    class LogicLayer : ILogic
    {

        public IPersistence MyPersitence { get; set; }

        public LogicLayer(IPersistence persistence)
        {
            //MyPersitence = new PersistenceLayer();
            MyPersitence = persistence;
        }
        public Athlete[] getAllAthletes()
        {

            Athlete[] athleteArray = MyPersitence.AllAthlete;

            Athlete temp;

            for (int i = 0; i < athleteArray.Length-1; i++)
            {
                for (int j = i+1; j < athleteArray.Length; j++)
                { 
                    if (athleteArray[i].Name.CompareTo(athleteArray[j].Name)>0)
                    {
                        temp = athleteArray[i];
                        athleteArray[i] = athleteArray[j];
                        athleteArray[j] = temp;
                    }
                }
            }


            return athleteArray;
        }

        public void insertAthlete(Athlete athlete)
        {
            Console.WriteLine(athlete);
        }

        public Athlete searchAthlete(string searchString)
        {
            Athlete[] athleteArray = MyPersitence.AllAthlete;

            foreach (var athlete in athleteArray)
            {
                if (athlete.Name.ToLower().Contains(searchString.ToLower())||athlete.Surname.ToLower().Contains(searchString.ToLower()))
                {
                    return athlete;
                }
            }
            return null;
        }
    }
}
