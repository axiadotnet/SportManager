using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Exceptions
{
    class AthleteNotFoundException : Exception
    {
        public override string Message => "Atleta non trovato";
    }
}
