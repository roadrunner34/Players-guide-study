using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Players_guide_study
{
    class Program
    {
        public static void Main(string[] args)
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

            Console.WriteLine("B value = " + b);
            Console.WriteLine("A Value = " + a);

            //code below is from chapter 6 about types
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This section contains work from chapter 6");
            System.Threading.Thread.Sleep(2000);

            byte asinglebyte = 34;
            short asingleshort = 12345;
            long averybignumber = 801706373123861;

            Console.WriteLine("byte: " + asinglebyte + ", short: " + asingleshort + ", long: " + averybignumber);
            asinglebyte = 244;
            asingleshort = -23861;
            averybignumber = -1234568485455;
            Console.WriteLine("Behind the scenes stuff occurs");
            Console.WriteLine("byte: " + asinglebyte + ", short: " + asingleshort + ", long: " + averybignumber);

            sbyte signedbyte = -23;
            ushort unsignedshort = 62000;
            uint unsignedint = 4000000000;
            ulong unsignedlong = 8017063731238611234;

            Console.WriteLine("signed byte: " + signedbyte + " unsigned short: " + unsignedshort + " unsigned int: " + unsignedint + " unsigned Long: " + unsignedlong);

            char favoriteletter = 'D';
            Console.WriteLine("My favorite Char is " + favoriteletter);


            //Chapter 7: Basic Math
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Chapter 7 Basic Math");
            System.Threading.Thread.Sleep(3000);

            int c = 3 + 4;
            int d = 5 - 2;

            //recommendation to use float or number for math with numbers. 
            float totalCost = 22.54f;
            float tipPercent = 0.18f;  //tip percent
            float tipAmount = totalCost * tipPercent;

            //Try it Out: calculate the area of a triangle
            float length = 5f;
            float width = 10f;
            float area = (width * length) * .5f;

            Console.WriteLine("The area of a triangle with a length of " + length + " and a width of " + width + " is " + area);

            //area = Areaoftriangle(length, width); 
            //Console.WriteLine("The area of a triangle with a length of "+length+" and a width of "+width+" is "+area);

            int totalApples = 23;
            int people = 7;
            int remainingapples = totalApples % people; //this will be 2

            Console.WriteLine(remainingapples);


            int e = 17;
            int f = 4;
            int quotient;
            int remainder;
            quotient = e / f;
            remainder = e % f;
            Console.WriteLine("Quotient= " + quotient + "and Remainder= " + remainder);

            //Start of Chapter 8: User Input
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Chapter 8: User Input");
            System.Threading.Thread.Sleep(3000);

            //Try it Out!
            //we will ask for the dimensions of a cyliner and provide the area and volume in return.
            Console.WriteLine("What is the height of the cylinder?");
            double CylinderHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the radius of the base of the cylinder?");
            double CylinderRadius = Convert.ToDouble(Console.ReadLine());
            double pi = 3.1415926;

            double CylinderVolume = pi * (CylinderRadius * CylinderRadius) * CylinderHeight;
            Console.WriteLine("The volume of the cylinder is: " + CylinderVolume);

            double CylinderSurfaceArea = 2 * pi * CylinderRadius * (CylinderRadius + CylinderHeight);
            Console.WriteLine("The Surface area of the cylinder is: " + CylinderSurfaceArea);
            Console.WriteLine("Press Any key to continue with the program");
            Console.ReadKey();


            //Start of Chapter 9: More Math
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Chapter 9: More Math");
            System.Threading.Thread.Sleep(3000);

            //Try it Out
			//What will happen in the following statements
			//double a = 1.0 +1 +1.0f
			//It will covert the 1.0 to a double as well as the 1.0f and end up with a 3 value
			double a1 = 1.0 + 1 + 1.0f;
			Console.WriteLine(a1);
			//int x = (int)(7+3.0/4.0*2)
			//It will first perform all the items in the parenthesis becoming (int)(8.5)
			//Then it will get converted to an int.  So it should end up being 8.
			int x = (int)(7 + 3.0 / 4.0 * 2);
			Console.WriteLine(x);
			//console.writeline((1+1)/2*3)
			//this will print out the value 3.
			Console.WriteLine((1 + 1) / 2 * 3);

        }
    }
}
