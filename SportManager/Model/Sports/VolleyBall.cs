using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model.Sports
{
    class VolleyBall: Sport
    {
        const double sportCaloryFactor = 1.25;

        public VolleyBall() : base("pallavolo", 10000) { }

        public override int CalcDailyCalory(double bMi)
        {
            double dailyCalory = (2000 * 25 * sportCaloryFactor)/ bMi;
            return (int)dailyCalory;
        }
    }
}
