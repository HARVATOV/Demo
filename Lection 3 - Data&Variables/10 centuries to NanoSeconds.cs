using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Practicing_Floating_Point_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double totalSeconds = hours * 3600 + minutes * 60 + seconds;
            double metersPerSeconds = meters / totalSeconds;
            double kilometerPerHours = metersPerSeconds *3.6;


            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometerPerHours);
            Console.WriteLine(kilometerPerHours* 0.621371192);



        }
    }
}
