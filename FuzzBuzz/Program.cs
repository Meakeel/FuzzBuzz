using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i.ToString() + " - " + IsFuzzBuzz(i));
            }
            Console.ReadKey();
        }

        public static string IsFuzzBuzz(int n)
        {
            //Need to check for FuzzBuzz first
            if (n % 3 == 0 && n % 5 == 0)
            {
                return "FuzzBuzz";
            }
            if (n % 3 == 0)
            {
                return "Fuzz";
            }
            if (n % 5 == 0)
            {
                return "Buzz";
            }

            return string.Empty;
        }
    }
}
