﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players_guide_study
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Code below is from chapter 5 about variables
            int score;
            score = 0;
            int meaningoflife = 42;
            Console.WriteLine(score);
            Console.WriteLine(meaningoflife);


            int a = 5;
            int b = 2;
            Console.WriteLine("B value = " + b);
            Console.WriteLine("A Value = " + a);

            b = a;
            a = -3;

            Console.WriteLine("B value = " +b);
            Console.WriteLine("A Value = " +a);

            //code below is from chapter 6 about types
            Console.WriteLine("This section contains work from chapter 6");
            byte asinglebyte = 34;
            short asingleshort = 12345;
            long averybignumber = 801706373123861;

            Console.WriteLine("byte: " +asinglebyte +", short: "+asingleshort+", long: "+averybignumber);
            asinglebyte = 244;
            asingleshort = -23861;
            averybignumber = -1234568485455;
            Console.WriteLine("Behind the scenes stuff occurs");
            Console.WriteLine("byte: " + asinglebyte + ", short: " + asingleshort + ", long: " + averybignumber);

            sbyte signedbyte = -23;
            ushort unsignedshort = 62000;
            uint unsignedint = 4000000000;
            ulong unsignedlong = 8017063731238611234;

            Console.WriteLine("signed byte: " +signedbyte +" unsigned short: " +unsignedshort+ " unsigned int: " +unsignedint+ " unsigned Long: " +unsignedlong);

            char favoriteletter = 'D';
            Console.WriteLine("My favorite Char is " +favoriteletter);




        }
    }
}
