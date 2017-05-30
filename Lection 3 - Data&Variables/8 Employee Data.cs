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
            int centuries = int.Parse(Console.ReadLine());
            int years = (centuries * 100);
            int days = (int)(years * 365.242);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong seconds =(ulong)( minutes * 60);
            ulong miliseconds = seconds * 1000;
            ulong microseconds = miliseconds * 1000;
            ulong nanseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years}  years = {days} " +
                $"days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {miliseconds} miliseconds = " +
                $"{microseconds} microseconds = {nanseconds} nanoseconds");

        }
    }
}
