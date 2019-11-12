using System;
using System.Collections.Generic;
using System.Text;
using SportManager.Model;

namespace SportManager
{
    class DataBasePersistenceLayer : IPersistence
    {
        Athlete[] IPersistence.AllAthlete { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IPersistence.SaveAthlete(Athlete a)
        {
            throw new NotImplementedException();
        }
    }
}
