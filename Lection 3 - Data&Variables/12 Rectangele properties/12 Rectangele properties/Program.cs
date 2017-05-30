using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Rectangele_properties
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            if ( number<-9223372036854775808 || number > 18446744073709551615)
            {
                Console.WriteLine("can't fit in any type");
            }
            Console.WriteLine($"{number} can fit in:");

            if (number > -128 && number<128)
            {
                Console.WriteLine("* sbyte");
            }

            if (number >0 && number < 255)
            {
                Console.WriteLine("* sbyte");
            }

            if (number > - 32758 && number < 32767)
            {
                Console.WriteLine("* short");
            }
            if (number >0 && number < 65535)
            {
                Console.WriteLine("* ushort");
            }
            if (number > -2147483648 && number < 2147483648)
            {
                Console.WriteLine("* int");
            }
            if (number > 0 && number < 4294967295)
            {
                Console.WriteLine("* uint");
            }
            if (number > -9223372036854775808 && number < 9223372036854775808)
            {
                Console.WriteLine("* long");
            }
            if (number > 0 && number < 18446744073709551615)
            {
                Console.WriteLine("* ulong");
            }

        }
    }
}
