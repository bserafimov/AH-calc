using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

          //  double doubleNumber;
          //  doubleNumber = 1234567890.12345;
          //  Console.WriteLine(doubleNumber.ToString("f2 # ### ###"));
          //  Console.WriteLine(doubleNumber.ToString("N", CultureInfo.InvariantCulture));
          //  Console.WriteLine("{0} G", doubleNumber.ToString("N4", CultureInfo.InvariantCulture));

            decimal value = 1234567890.62m;
            string specifier;
           
            // Use custom numeric format specifiers.
            specifier = "0,0.000";
            Console.WriteLine("1. format [{0}] ; result: {1}", specifier, value.ToString("#,0.#0"));

            // specifier = "# #.00#;- #,#.00#";
            // Console.WriteLine("2. {0}: {1}", specifier, (value * -1).ToString(specifier));


        }
    }
}
