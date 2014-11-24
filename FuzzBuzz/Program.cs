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
        }

        public static string IsFuzzBuzz(int n)
        {
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
