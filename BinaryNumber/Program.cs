using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine("Binary Number is:  {0}", binary);

            Console.ReadKey();

        }
    }
}
