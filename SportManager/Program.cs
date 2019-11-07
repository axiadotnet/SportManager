using SportManager.Model;
using System;

namespace SportManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Athlete C1 = new Athlete("mario", "rossi", 20, Gender.Male);
            C1.Age = -19;

            Athlete c2 = new Athlete("GG01371347019", "Giorgio", "Gori", Gender.Male, DateTime.Now, 25, 1.82, 89);
            Console.WriteLine(c2);
        }
    }
}
