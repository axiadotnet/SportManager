using SportManager.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager
{
    interface IPersistence //tutte le classi che avranno a che fare con Persistence, dovranno avere almeno quel metodo
    {
        IEnumerable<Athlete> AllAthlete { get; set; }
        void SaveAthlete(Athlete a);
    }
}
