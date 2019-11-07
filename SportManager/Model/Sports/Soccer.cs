using System;
using System.Collections.Generic;
using System.Text;

namespace SportManager.Model.Sports
{
    internal class Soccer : Sport
    {
        const double sportCaloryFactor = 1.35;
        public Soccer():base("calcio", 100000){}

        public override int CalcDailyCalory(double bMi)
        {
            double dailyCalory = (2000 * 25 * sportCaloryFactor) / bMi;
            return (int)dailyCalory;
        }
    }
}
