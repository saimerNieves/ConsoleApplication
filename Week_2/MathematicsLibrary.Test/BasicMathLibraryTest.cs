using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

//Class Lecture remake Week 1
//Hey Corey I remade the assignment since I pushed a github repo within another repo and it was causing build issues. As a result I just ended up making a seperate Repo for this assignment and I will add this one to it.
//From Now on I will make a repo for each assignment and make them public.
//Saimer Nieves

namespace MathematicsLibrary.Test
{
    public class BasicMathLibraryTest
    {
       // public static BasicMathLibrary BasicMathLibrary = new BasicMathLibrary(); //testing out
       // public static AdvMathLibrary AdvMathLibrary = new AdvMathLibrary();


        [Fact] //Declares a test method thats run by the test runner  //TEST METHOD
        public void TestAddNumbers()
        {
            var math = new BasicMathLibrary(); //new instance of Basic Math Library
            var result_addition = math.AddNumbers(5, 5);
            Assert.True(result_addition == 10);   // Way to test test medthods



        }

        [Fact]//TEST METHOD
        public void TestSubtractNumbers()
        {
            var math = new BasicMathLibrary(); //new instance of Basic Math Library
            var result_subtraction = math.SubtractNumbers(10, 3);
            Assert.True(result_subtraction == 7);//way to test test method
        }



        [Fact]//Test Method
        public void TestMultiplyNumbers()
        {
            var math = new BasicMathLibrary(); //new instance of Basic Math Library
            var result_multiplication = math.MultiplyNumbers(5, 6);
            Assert.True(result_multiplication == 30);
        }

        [Fact]

        public void TestDivideNumbers()
        {
            var math = new BasicMathLibrary(); //new instance of Basic Math Library
            var result_division = math.DivideNumbers(50, 5);
            Assert.True(result_division == 10);
        }





        //Assignment Below for Advanced Math Library

        [Fact]
        public void TestAreaOfRectangleCalculator()
        {
            var advMathInstance = new AdvMathLibrary();

            var areaResults = advMathInstance.areaOfRectangleCalculator(2, 10);
            Assert.True(areaResults == 20);

        }

        [Fact]
        public void TestAverageOfDoubleCalculator()
        {
            var advMathInstance = new AdvMathLibrary();
            var listOfDoubles = new List<double>(5) { 0, 1, 2, 3.5, 10 };

            var averageOfList = advMathInstance.averageOfDoubleCalculator(listOfDoubles);
            Assert.True(averageOfList == 3.3);

        }

        [Fact]
        public void TestSquareNumberCalculator()
        {
            var advMathInstance = new AdvMathLibrary();

            var numberSquared = advMathInstance.squareNumberCalculator(5);
            Assert.True(numberSquared == 25);

        }

        [Fact]
        public void TestPythogereanTheoremCalculator()
        {
            var advMathInstance = new AdvMathLibrary();

            var hypothenuseSide = advMathInstance.pythogereanTheoremCalculator(3, 4);
            Assert.True(hypothenuseSide == 5);

        }



        [Fact]
        public void TestAreaOfTriangleCalculator()
        {
            var advMathInstance = new AdvMathLibrary();

            var triangleArea = advMathInstance.areaOfTriangleCalculator(3, 4);
            Assert.True(triangleArea == 6);

        }



        [Fact]
        public void TestAreaOfCircleCalculator()
        {
            var advMathInstance = new AdvMathLibrary();

            var circleArea = Math.Round(advMathInstance.areaOfCircleCalculator(3),2);//rounded to 2 decimals since is a continuous number
            Assert.True(circleArea == 28.27); 

        }











    }
}
