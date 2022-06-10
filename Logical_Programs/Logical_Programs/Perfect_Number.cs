using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    class Perfect_Number
    {
        public bool Factors(int Number, int potential_factor)
        {
            if (Number % potential_factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Perfectnum()
        {
            int check = 0;
            Console.WriteLine("Enter the number you want to check: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number / 2; i++)
            {
                if (Factors(Number, i))
                {
                    check += i;

                }
            }
            if (check == Number)
            {
                Console.WriteLine(Number + " Is a Perfect Number");
            }
            else
            {
                Console.WriteLine(Number + "is not a perfect Number");

            }
        }

    }
}

