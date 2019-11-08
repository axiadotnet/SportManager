using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;

namespace SportManager
{
    class LogicLayer : ILogic
    {

        public IPersistence myPersitence { get; set; }

        public LogicLayer()
        {
            myPersitence = new PersistenceLayer();
        }
        public Athlete[] getAllAthletes()
        {
            Athlete[] athleteArray = myPersitence.AllAthlete;
            return athleteArray;
        }

        public void insertAthlete(Athlete athlete)
        {
            throw new NotImplementedException();
        }

        public Athlete searchAthlete(string name)
        {
            throw new NotImplementedException();
        }
    }
}
