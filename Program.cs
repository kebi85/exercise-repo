﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var fact = 1;
            do
            {
                fact = n * fact;
                n--;
            } while (n>1);
            Console.WriteLine(fact);
        }
    }
}
