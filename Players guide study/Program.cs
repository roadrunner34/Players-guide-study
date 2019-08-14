using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Players_guide_study
{
    //Enumarating months of year for Try it out in Chapter 14
    enum MonthsOfYear { January=1,February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11,December=12};
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please choose a chapter to review.  Chapters 5-15 are currently available");
            int chapterselect = Convert.ToInt32(Console.ReadLine());
            switch (chapterselect)
                {

                case 5:
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
                    break;
                case 6:
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
                    break;

                case 7:
                    //Chapter 7: Basic Math
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Chapter 7 Basic Math");
                    System.Threading.Thread.Sleep(3000);

                    //int c = 3 + 4;
                    //int d = 5 - 2;

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
                    break;

                case 8:
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
                    break;

                case 9:
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
                    break;

                case 10:
                    //Start of Chapter 10: Decision Making
                    //central part of decision making is the if statement
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Chapter 10: Decision Making");
                    System.Threading.Thread.Sleep(3000);
                    //Try it Out:We will be checking to see if a number from the user is even or odd.
                    Console.WriteLine("We are checking if a number is even or odd.  Please enter a number:");
                    int evenorodd = Convert.ToInt32(Console.ReadLine());
                    int evenoroddremainder = evenorodd % 2;
                    if (evenoroddremainder == 0)
                    {
                        Console.WriteLine("The value you entered is even");
                    }
                    else
                    {
                        Console.WriteLine("The value you entered is odd");
                    }

                    //Try it out 2: Positive or Negative:
                    //We are writing a program to check if numbers are positive or negative before the calculation to determine whether the result should be positive or negative

                    Console.WriteLine("Hello, we are going to determine if the product of 2 numbers you give us is going to be positive or negative");
                    Console.WriteLine("Number 1:");
                    int numberone = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Number 2:");
                    int numbertwo = Convert.ToInt32(Console.ReadLine());
                    if (numberone > 0 && numbertwo > 0)
                    {
                        Console.WriteLine("The resulting product of these numbers will be positive");
                    }
                    if (numberone > 0 && numbertwo < 0)
                    {
                        Console.WriteLine("The resulting product of these numbers will be negative");
                    }
                    if (numberone < 0 && numbertwo > 0)
                    {
                        Console.WriteLine("The resulting product of these numbers will be negative");
                    }
                    if (numberone < 0 && numbertwo < 0)
                    {
                        Console.WriteLine("The resulting product of these numbers is positive");
                    }
                    Console.WriteLine("The result is = " + numberone * numbertwo);
                    break;

                case 11:
                    //Start of Chapter 11: Switch Statements
                    //An Alternative to if statements
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Chapter 11: Switch Statements");
                    System.Threading.Thread.Sleep(2000);

                    //Try it out:
                    //We are going to make a simple calculator that is going to allow the user to do math with 2 numbers and an operator, either +, -, *, /, or %.  Also can use ^ for power

                    Console.WriteLine("Hello, let's do some math");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("I will need to know 2 numbers then an operator that you want to do for those numbers.");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("An example is entering 2, 3, and then *.  This means that you want to multiply 2*3");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("So please give me two numbers then an operator.  Either +, -, *, /, % (remainder) or ^");
                    int firstnumber = Convert.ToInt32(Console.ReadLine());
                    int secondnumber = Convert.ToInt32(Console.ReadLine());
                    String mathoperator = Console.ReadLine();

                    switch (mathoperator)
                    {
                        case "+":
                            Console.WriteLine(firstnumber + secondnumber);
                            break;
                        case "-":
                            Console.WriteLine(firstnumber - secondnumber);
                            break;
                        case "*":
                            Console.WriteLine(firstnumber * secondnumber);
                            break;
                        case "/":
                            Console.WriteLine(firstnumber / secondnumber);
                            break;
                        case "%":
                            Console.WriteLine(firstnumber % secondnumber);
                            break;
                        case "^":
                            Console.WriteLine(Math.Pow(firstnumber, secondnumber));
                            break;
                        default:
                            Console.WriteLine("You did not enter a correct operator");
                            break;
                    }

                            break;

                case 12:
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Chapter 12: Looping");
                    System.Threading.Thread.Sleep(2000);
                    //In a nutshell, while, do-while, and for loops allows us to repeat things in various ways
                    //While Loop: it will repeat certain code over and over again as long as a certain condition is true.  They look kinds of like an if statement
                    //Example:
                    //int c = 1;
                    //while (c<=10)
                    //{
                    //    Console.Write(c);
                    //    c++;
                    //}

                    for(int row1=0; row1 <5; row1++)
                    {
                        for(int column1=0; column1<row1+1; column1++)
                            Console.Write("*");

                        Console.WriteLine();
                    }

                    //Try it Out.  Print a Pyramid
                    //I will want to to create a pyramid made out of starts.
                    for (int row = 0; row < 5; row++)
                    {

                        for (int space = 0; space < 5-row-1; space++)
                            Console.Write(" ");
                        
                        for (int asterisk = 0; asterisk <row*2+1; asterisk++)
                            Console.Write("*");
                        
                        Console.WriteLine();

                    }

                                        //Try it out FizzBizz

                    for (int printnumber = 1; printnumber <=100; printnumber++)
                    {
                        if(printnumber%3==0 && printnumber%5==0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if(printnumber%3==0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if(printnumber%3!=0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(printnumber);
                        }
                    }

                    //End of Chapter 12.  All Chapter 12 code should be before this Break
                    break;

                case 13:
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Chapter 13: Arrays");
                    System.Threading.Thread.Sleep(2000);

                    //Try it Out!
                    //Copying an Array.  Write code to copy an array.  
                    //First create an initial array with 10 items.
                    //Second ceate a second array variable, the same size as the original.
                    //Then use a loop to read values from the original array and place them in the new array.
                    //The print them both out to check that you complete it correctly.

                    int[] firstarray = new int[] { 10, 9, 8, 7, 5, 3, 2, 1, 0, 32 };
                    int[] secondarray = new int[firstarray.Length];

                    for (int copyindex = 0; copyindex < firstarray.Length; copyindex++)
                        secondarray[copyindex] = firstarray[copyindex];

                    for (int firstarrayindex = 0; firstarrayindex<firstarray.Length; firstarrayindex++)
                        Console.Write(firstarray[firstarrayindex] +" ");
                    Console.WriteLine();
                    for (int secondarrayindex = 0; secondarrayindex < secondarray.Length; secondarrayindex++)
                        Console.Write(firstarray[secondarrayindex] +" ");
                    Console.WriteLine();

                    //Example of Array of Arrays or a Jagged Array
                    int[][] matrix = new int[4][];
                    matrix[0] = new int[2];
                    matrix[1] = new int[6];
                    matrix[2] = new int[3];
                    matrix[3] = new int[2];
                    

                    for (int row = 0; row<matrix.Length; row++)
                    {
                        for(int column = 0; column<matrix[row].Length; column++)
                            Console.Write(matrix[row][column]+" ");

                        Console.WriteLine();
                    }

                    //Try it Out!  Minimum and Averages revisited.  Use the Foreach loop to go through and find the minimum value and the average of values
                    //Minimum Value
                    int[] minimumArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
                    int currentMinimum = Int32.MaxValue;

                    foreach(int tiny in minimumArray)
                    {
                        if (tiny < currentMinimum)
                            currentMinimum = tiny;
                    }
                    Console.WriteLine("The minimum value is: "+currentMinimum);

                    //For the Average value in the array
                    int[] averageArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
                    int total = 0;

                    foreach (int averageValue in averageArray)
                        total += averageValue;

                    float finalAverageValue = (float)total / averageArray.Length;
                    Console.WriteLine("The average value in the array is: "+ finalAverageValue);


                    //End of Chapter 13. All Chapter 13 code should be before this break.
                    break;

                case 14:
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Chapter 14: Enumeration");
                    System.Threading.Thread.Sleep(2000);

                    //Try it out: Months of Year.  Using DaysOfWeek as an example, create an enumeration to reprsent months of year, and assign ethem values of 1-12
                    Console.WriteLine("Please Give a number between 1 & 12");
                    int InputedNumber = Convert.ToInt32(Console.ReadLine());
                        
                                switch (InputedNumber)
                                {
                                    case 1:
                                        Console.WriteLine("You Picked January");
                                        break;
                                    case 2:
                                        Console.WriteLine("You Picked February");
                                        break;
                                    case 3:
                                        Console.WriteLine("You Picked March");
                                        break;
                                    case 4:
                                        Console.WriteLine("You Picked April");
                                        break;
                                    case 5:
                                        Console.WriteLine("You Picked May");
                                        break;
                                    case 6:
                                        Console.WriteLine("You Picked June");
                                        break;
                                    case 7:
                                        Console.WriteLine("You Picked July");
                                        break;
                                    case 8:
                                        Console.WriteLine("You Picked August");
                                        break;
                                    case 9:
                                        Console.WriteLine("You Picked September");
                                        break;
                                    case 10:
                                        Console.WriteLine("You Picked October");
                                        break;
                                    case 11:
                                        Console.WriteLine("You Picked November");
                                        break;
                                    case 12:
                                        Console.WriteLine("You Picked Ecember");
                                        break;

                                    default:
                                        {
                                            Console.WriteLine("You were supposed to input a number between 1 & 12.  Shame");
                                            break;
                                        }
                                }

                      

                    //End of Chapter 14. All Chapter 14 code should be before this break.
                    break;

                    case 15:
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Chapter 15: Methods");
                    System.Threading.Thread.Sleep(2000);



                    //End of Chapter 15. All Chapter 14 code should be before this break.
                    break;



                //This breaks the Switch Statement.  All code should be before this.
                default:
                    {
                        Console.WriteLine("No chapter work exists for that value: "+chapterselect);
                        break;
                    }

            }

        }
    }
}
