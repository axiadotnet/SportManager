﻿using SportManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager
{
    interface ILogic
    {
        IEnumerable<Athlete> getAllAthletes();
        Athlete searchAthlete(string name);
        void insertAthlete(Athlete athlete);
    }
}
