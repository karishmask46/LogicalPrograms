﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Reverse_Number
    {
        public void FindReverseNum()
        {
            Console.WriteLine("Enter a number :");
            int Number = int.Parse(Console.ReadLine());

            int Reverse = 0;

            while (Number > 0)

            {

                int remainder = Number % 10;

                Reverse = (Reverse * 10) + remainder;

                Number = Number / 10;

            }

            Console.WriteLine("Reverse No. is {0}", Reverse);

            Console.ReadLine();
        }

    }
}

