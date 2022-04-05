using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    public static class HW1
    {
        public static void SolveTaskOne()
        {
            Console.WriteLine("\nHW1 VARIABLES");
            Console.WriteLine("\nEx1");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double intResult = DivideParamsInteger(numberA, numberB);
            double lessResult = DivideParamsLess(numberA, numberB);
            Console.WriteLine($"{intResult}, {lessResult}");
        }
        public static void SolveTaskTwo()
        {
            Console.WriteLine("\nEx2");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double result = CalculateFormula(numberA, numberB);
            Console.WriteLine(result);
        }
        public static void SolveTaskThree()
        {
            Console.WriteLine("\nEx3");
            string a = UI.GetStringFromUser("a");
            string b = UI.GetStringFromUser("b");
            string result = ReplaceTwoStrings(a, b);
            Console.WriteLine(result);
        }
        public static void SolveTaskFour()
        {
            Console.WriteLine("\nEx4");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double numberC = UI.GetNumberFromUser("c");
            double result = SolveAcuation(numberA, numberB, numberC);
            Console.WriteLine(result);
        }
        public static void SolveTaskFive()
        {
            Console.WriteLine("\nEx5");
            double pointOneX = UI.GetNumberFromUser("x1");
            double pointOneY = UI.GetNumberFromUser("y1");
            double pointTwoX = UI.GetNumberFromUser("x2");
            double pointTwoY = UI.GetNumberFromUser("y2");
            double k = CalculateCoefficientKForLineAcuation(pointOneX, pointOneY, pointTwoX, pointTwoY);
            double b = CalculateCoefficientBForLineAcuation(k, pointTwoX, pointTwoY);
            string result = $"Result: y = {k}*x + {b}";
            Console.WriteLine(result);
        }

        public static int DivideParamsInteger(double numberA, double numberB)
        {
            if (numberB == 0)
            {
                throw new DivideByZeroException("Number B must not be 0");
            }
            int result = Convert.ToInt32(numberA / numberB);
            return result;
        }
        public static int DivideParamsLess(double numberA, double numberB)
        {
            if (numberB == 0)
            {
                throw new DivideByZeroException("Number B must not be 0");
            }
            int result = Convert.ToInt32(numberA % numberB);
            return result;
        }
        public static double CalculateFormula(double numberA, double numberB)
        {
            if (numberA == numberB)
            {
                throw new DivideByZeroException("Numbers must have different values");
            }
            double result = (numberA * 5 + numberB * numberB) / (numberB - numberA);
            return result;
        }
        public static string ReplaceTwoStrings(string aString, string bString)
        {
            string a = aString;
            string b = bString;
            string tmp = a;
            a = b;
            b = tmp;
            string result = $"{a}, {b}";
            return result;
        }
        public static double SolveAcuation(double numberA, double numberB, double numberC)
        {
            if (numberA == 0)
            {
                throw new DivideByZeroException("Number A must not be 0");
            }
            double result = (numberC - numberB) / numberA;
            return result;
        }
        public static double CalculateCoefficientKForLineAcuation(double pointOneX, double pointOneY, double pointTwoX, double pointTwoY)
        {
            if (pointOneX == pointTwoX)
            {
                throw new DivideByZeroException("x.point1 and x.point2 must have different values");
            }
            double k = (pointOneY - pointTwoY) / (pointOneX - pointTwoX);
            return k;
        }
        public static double CalculateCoefficientBForLineAcuation(double k, double pointTwoX, double pointTwoY)
        {
            double b = pointTwoY - k * pointTwoX;
            return b;
        }
    }
}
