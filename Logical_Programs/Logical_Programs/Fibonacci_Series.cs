using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Fibonacci_Series
    {
        public void fibo_series()
        {

            Console.WriteLine("Enter The Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int Num1 = 0;
            int Num2 = 1;
            int Num3;
            Console.WriteLine(Num1);
            Console.WriteLine(Num2);




            for (int i = 2; i < Num; i++)
            {

                Num3 = Num1 + Num2;
                Console.WriteLine(Num3);

                Num1 = Num2;
                Num2 = Num3;


            }


        }
    }
}

