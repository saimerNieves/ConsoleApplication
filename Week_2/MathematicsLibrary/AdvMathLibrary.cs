using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathematicsLibrary
{
    public class AdvMathLibrary
    {

        //Member Functions


        //This function calculates the area of a shape --> Length x Width
        public double areaOfRectangleCalculator(double length, double width) {

            return length * width; //returns double area
        }


        //This function calculates the average of a list of Doubles
        public double averageOfDoubleCalculator(List<double> listOfDoubles) {

            int sizeOfListOfDoubles = listOfDoubles.Count();
            double totalSumOfDoubles = 0;

            foreach(double number in listOfDoubles){

                totalSumOfDoubles += number;
            }

            return totalSumOfDoubles / sizeOfListOfDoubles; //returns average in double
        
        }

        //This function calculates a number square
        public double squareNumberCalculator(double numberToSuare) {

            return Math.Pow(numberToSuare,2); //returns squared number in double
        }

        //This function calculates the hypothenuse side  of a 90 degree triangle using the pythagorean theorem 
        public double pythogereanTheoremCalculator(double a, double b) {

            double cSquared  = Math.Pow(a, 2) + Math.Pow(b, 2); //return c squared as a double
            return Math.Sqrt(cSquared);//return c squared as a double

        }


        //This function calculates the area of a triangle --> Length x Width
        public double areaOfTriangleCalculator(double length, double width)
        {
            return (length * width)/2; //returns double area
        }


        //This function calculates the area of a circle --> Length x Width
        public double areaOfCircleCalculator(double radius)
        {
            double pi = 3.1415926535;
            return pi * Math.Pow(radius, 2); //returns double area
        }
    }
}
