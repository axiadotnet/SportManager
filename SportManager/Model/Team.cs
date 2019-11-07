using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model
{
    class Team
    {
        private Athlete[] atleti; 
        public Athlete[] Atleti { get; set; }

        public Team(Athlete[] atleti)
        {
            Atleti = atleti;
        }
    }
}
