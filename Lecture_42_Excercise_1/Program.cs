﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_42_Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var number = Int32.Parse(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine(Valid);
            }
            else
            
                Console.writeline(Invalid);


            ShowExit();
        }

        static void Showexit()
        {
            Console.WriteLine("Press any key to exit");
            Console.WriteLine();
        }
    }
}
