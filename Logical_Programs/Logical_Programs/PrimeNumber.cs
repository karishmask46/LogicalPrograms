using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class PrimeNumber
    {
        public void Prime_Number()
        {
            Console.WriteLine("Enter The Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int j = 0;

            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    j = 1;
                    break;
                }

            }
            if (j == 1)
            {
                Console.WriteLine(Num + " Is Not a Prime Number");
            }
            else
            {
                Console.WriteLine(Num + "  Is a Prime Number");

            }

        }
    }
}

