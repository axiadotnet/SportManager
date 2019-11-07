using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model.Sports
{
    class Tennis: Sport
    {
        const double sportCaloryFactor = 1.50;
        public Tennis() : base("tennis", 75000) { }

        public override int CalcDailyCalory(double bMi)
        {
            double dailyCalory = (2000 * 25 * sportCaloryFactor) / bMi;
            return (int)dailyCalory;
        }
    }
}
