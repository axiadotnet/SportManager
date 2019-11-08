using SportManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager
{
    interface IPersistence
    {
        Athlete[] AllAthlete { get; set; }
        void SaveAthlete(Athlete a);
    }
}
