﻿namespace Logical_Programs
{
    class logicalProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for Perfect Number:");
            Console.WriteLine("1 for a perfect number");
            Console.WriteLine("2 for a reverse number");
            Console.WriteLine("3 for a Prime Number7");
            int hammer = Convert.ToInt32(Console.ReadLine());
            switch (hammer)
            {
                case 1:
                    Perfect_Number logic = new Perfect_Number();
                    logic.Perfectnum();
                    break;
                    case 2:
                    Reverse_Number reverse = new Reverse_Number();
                    reverse.FindReverseNum();
                    break;
                case 3:
                    PrimeNumber primeNum = new PrimeNumber();
                    primeNum.Prime_Number();
                    break;

            }
           
           
        }
    }

}

