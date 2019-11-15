using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        public IEnumerable<Athlete> getAllAthletes()
        {

            List<Athlete> athleteList = MyPersitence.AllAthlete.ToList();

            //Athlete temp;

            //for (int i = 0; i < athleteArray.Length-1; i++)
            //{
            //    for (int j = i+1; j < athleteArray.Length; j++)
            //    { 
            //        if (athleteArray[i].Name.CompareTo(athleteArray[j].Name)>0)
            //        {
            //            temp = athleteArray[i];
            //            athleteArray[i] = athleteArray[j];
            //            athleteArray[j] = temp;
            //        }
            //    }
            //}

            //athleteList.Sort();

            //athleteList.Sort((a1,a2) => a1.Name.CompareTo(a2.Name));

            AthleteComparer comparer = new AthleteComparer(AthleteOrderType.Weight);
            athleteList.Sort(comparer);

            return athleteList;
        }

        

        public void insertAthlete(Athlete athlete)
        {
            try
            {
                MyPersitence.SaveAthlete(athlete);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Trace.TraceError("errore");
            }
            
        }

        public Athlete searchAthlete(string searchString)
        {
            IEnumerable<Athlete> athletes = MyPersitence.AllAthlete;

            foreach (var athlete in athletes)
            {
                if (athlete.Name.ToLower().Contains(searchString.ToLower())||athlete.Surname.ToLower().Contains(searchString.ToLower()))
                {
                    return athlete;
                }
            }

            throw new Exception();
            
        }
    }
}
