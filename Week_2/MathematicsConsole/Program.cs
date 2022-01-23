using MathematicsLibrary;
using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;
using System.Linq;

namespace MathematicsConsole
{
    class Program
    {
        //Initialized Private Variable
        private static double _num1;
        private static double _num2;
        private static string _operand;

        private static List<double> _listOfDoubles;


        static void Main()
        {

            string[] args = Environment.GetCommandLineArgs(); //return all command line arguments

            //loop through array

            /*  foreach(var a in args)
              {
                  Console.WriteLine(a);

              }*/

            //Validate arguments
            AreArgumentsValid(args);

            var math = new BasicMathLibrary();
            var advMath = new AdvMathLibrary();

            //Printing this out
            switch (_operand)
            {
                case "add":
                    Console.WriteLine($"Function Called( add )  => Calculation: {_num1} + {_num2} = {math.AddNumbers(_num1, _num2)}");
                    break; //get out of switch statement

                case "sub":
                    Console.WriteLine($"Function Called( sub )  => Calculation: {_num1} - {_num2} = {math.SubtractNumbers(_num1, _num2)}");
                    break;

                case "mul":
                    Console.WriteLine($"Function Called( mul )  => Calculation: {_num1} x {_num2} = {math.MultiplyNumbers(_num1, _num2)}");
                    break;

                case "div":
                    Console.WriteLine($"Function Called( div )  => Calculation: {_num1} / {_num2} = {math.DivideNumbers(_num1, _num2)}");
                    break;

                case "squarenumber":
                    Console.WriteLine($"Function Called( squarenumber )  => Calculation: {_num1} * {_num1} = {advMath.squareNumberCalculator(_num1)}");
                    break;

                case "trianglearea":
                    Console.WriteLine($"Function Called( triangleArea )  => Calculation: (Length: {_num1} * Width: {_num2}) / 2 = {advMath.areaOfTriangleCalculator(_num1, _num2)}");
                    break;

                case "rectanglearea":
                    Console.WriteLine($"Function Called( rectangleArea )  => Calculation: Length: {_num1} * Width: {_num2} = Area: {advMath.areaOfRectangleCalculator(_num1,_num2)}");
                    break;

                case "trianglecside":
                    Console.WriteLine($"Function Called( triangleCSide )  => Calculation: A Side:{_num1}  , B Side:  {_num2} = C Side: {Math.Round(advMath.pythogereanTheoremCalculator(_num1,_num2),2)}");
                    break;

                case "circlearea":
                    Console.WriteLine($"Function Called( circleArea )  => Calculation: Radius: {_num1},  Area = {Math.Round(advMath.areaOfCircleCalculator(_num1),2)}");
                    break;

                case "listaverage":
                    Console.WriteLine($"Function Called( listAverage )  => Calculation for average of: {string.Join(",", _listOfDoubles)} = Average: {advMath.averageOfDoubleCalculator(_listOfDoubles)}");
                    break;

               // default: //go to this statement if is none of these
                 //   Console.WriteLine($"{_operand} is not a valid Operand option. Please Enter Add, Sub, Mul, Div");
                   // break;
            }

            Console.ReadLine(); // added this so terminal wouldn't close
        }


        //Created arguments validation function
        public static void AreArgumentsValid(string[] args)
        {

            _operand = args[1].ToLower();



            switch (_operand)
            {
                //Basic Math Statements
                case "add": case "sub": case "mul":case "div": case "trianglearea":  case "rectanglearea": case "trianglecside":

                    if ((args.Length - 1) == 3) //subracted Path position
                    {
                        _num1 = NumParser(args[2]);
                        _num2 = NumParser(args[3]);
                    }
                    else
                    {
                        Console.WriteLine($"Error: The Operation: {_operand} must have and only have 2 numbers");

                        Console.ReadLine(); // added this so terminal wouldn't close
                        Environment.Exit(99); //exit the console application
                    }
                    break; //get out of switch statement


                //Advanced Math Statements
                case "circlearea":  case "squarenumber":

                    

                    if ( (args.Length -1) == 2 ) //subracted Path position
                    {
                        _num1 = NumParser(args[2]);

                    }
                    else
                    {
                        Console.WriteLine($"Error: The Operation {_operand} must have and only have 1 Parameter");

                        Console.ReadLine(); // added this so terminal wouldn't close
                        Environment.Exit(99); //exit the console application
                    }

                    break; //get out of switch statement

                case "listaverage":

                    if ((args.Length - 1) != 1) //subracted Path position
                    {
                        List<string> listOfInputedStringDoubles = args.ToList();
                        listOfInputedStringDoubles.RemoveRange(0,2);

                        List<double> listOfParsedDoubles = new List<double> ( listOfInputedStringDoubles.Count );

                        foreach (String doubleAsString in listOfInputedStringDoubles)
                        {
                            try
                            {
                                listOfParsedDoubles.Add(Double.Parse(doubleAsString));
                            }
                            catch 
                            {
                                Console.WriteLine($"Error: Unable to parse {doubleAsString} as a double");
                                Environment.Exit(99); //exit the console application
                            }
                        }

                        _listOfDoubles = listOfParsedDoubles;

                    }
                    else
                    {
                        Console.WriteLine($"Error: The Operation {_operand} must Carry one or more parameters");
                        Environment.Exit(99); //exit the console application
                    }

                    break;


                default: //go to this statement if is none of these
                    Console.WriteLine($"Error: {_operand} is not a valid Operand option. Please Enter Add, Sub, Mul, Div, squarenumber, trianglearea , rectanglearea , trianglecside , circlearea , listaverage");
                    Environment.Exit(99); //exit the console application
                    break;
            }



            Console.WriteLine("All Arguments are Valid!"); //This means that if you made it to this line your app didnt crash and you can view successfully
            //Console.ReadLine(); //stops console app for us to read
        }


        //Checks to see if numbers are valid
        public static double NumParser(string arg) { //resualble number parser

            double number;

            if (Double.TryParse(arg, out number)) //if parsable set to num 1
            {

                return number; //set class level variable  = to local level variable
            }
            else
            {

                Console.WriteLine($"Unable to parse {arg}."); //else print out an error
                Environment.Exit(99); //exit the console application
            }

            return 0;

        }
    }
}
