using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    public static class HW2
    {
        public static void SolveTask1()
        {
            Console.WriteLine("\nHW2 BRANCHING STRUCTURES");
            Console.WriteLine("\nEx1");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double result = DoMathForTask1(numberA, numberB);
            Console.WriteLine(result);
        }
        public static void SolveTask2()
        {
            Console.WriteLine("\nEx2");
            double pointX = UI.GetNumberFromUser("x");
            double pointY = UI.GetNumberFromUser("y");
            int fourth = GetFourthOfPoint(pointX, pointY);
            Console.WriteLine(fourth);
        }
        public static void SolveTask3()
        {
            Console.WriteLine("\nEx3");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double numberC = UI.GetNumberFromUser("c");
            double max = FindMax(numberA, numberB, numberC);
            double mid = FindMid(numberA, numberB, numberC);
            double min = FindMin(numberA, numberB, numberC);
            string result = $"{min} {mid} {max}";
            Console.WriteLine(result);
        }
        public static void SolveTask4()
        {
            Console.WriteLine("\nEx4");
            double numberA = UI.GetNumberFromUser("a");
            double numberB = UI.GetNumberFromUser("b");
            double numberC = UI.GetNumberFromUser("c");
            double discriminant = CalculateDiscriminant(numberA, numberB, numberC);
            string result = "no roots";
            double rootOne;
            double rootTwo;
            if (discriminant > 0)
            {
                rootOne = CalculateRootOne(numberA, numberB, discriminant);
                rootTwo = CalculateRootTwo(numberA, numberB, discriminant);
                result = $"{rootOne}, {rootTwo}";
            }
            else if (discriminant == 0)
            {
                rootOne = CalculateRootOne(numberA, numberB, discriminant);
                result = $"{rootOne}";
            }
            Console.WriteLine(result);
        }
        public static void SolveTask5()
        {
            Console.WriteLine("\nEx5");
            int number = Convert.ToInt32(UI.GetNumberFromUser("from 10 to 99"));
            string result = ConvertNumberToString(number);
            Console.WriteLine(result);
        }
        public static double DoMathForTask1(double numberA, double numberB)
        {
            double result = 0d;
            if (numberA > numberB)
            { result = numberA + numberB; }
            else if (numberA == numberB)
            { result = numberA * numberB; }
            else
            { result = numberA - numberB; }
            return result;
        }
        public static int GetFourthOfPoint(double pointX, double pointY)
        {
            int fourth;
            if (pointX > 0 && pointY > 0)
            { fourth = 1; }
            else if (pointX > 0 && pointY < 0)
            { fourth = 4; }
            else if (pointX < 0 && pointY < 0)
            { fourth = 3; }
            else if (pointX < 0 && pointY > 0)
            { fourth = 2; }
            else if (pointX > 0 && pointY == 0)
            { fourth = 14; }
            else if (pointX == 0 && pointY < 0)
            { fourth = 34; }
            else if (pointX < 0 && pointY == 0)
            { fourth = 23; }
            else if (pointX == 0 && pointY > 0)
            { fourth = 12; }
            else
            { fourth = 1234; }
            return fourth;
        }
        public static double FindMax(double numberA, double numberB, double numberC)
        {
            double max = 0;
            if (numberA >= numberB && numberA >= numberC)
            { max = numberA; }
            else if (numberB >= numberA && numberB >= numberC)
            { max = numberB; }
            else if (numberC >= numberA && numberC >= numberB)
            { max = numberC; }
            return max;
        }
        public static double FindMid(double numberA, double numberB, double numberC)
        {
            double mid = 0;
            if (numberA >= numberB && numberA <= numberC
                || numberA <= numberB && numberA >= numberC)
            { mid = numberA; }
            else if (numberB >= numberA && numberB <= numberC
                || numberB <= numberA && numberB >= numberC)
            { mid = numberB; }
            if (numberC >= numberA && numberC <= numberB
                || numberC <= numberA && numberC >= numberB)
            { mid = numberC; }
            return mid;
        }
        public static double FindMin(double numberA, double numberB, double numberC)
        {
            double min = 0;
            if (numberA <= numberB && numberA <= numberC)
            { min = numberA; }
            else if (numberB <= numberA && numberB <= numberC)
            { min = numberB; }
            else if (numberC <= numberA && numberC <= numberB)
            { min = numberC; }
            return min;
        }
        public static double CalculateDiscriminant(double numberA, double numberB, double numberC)
        {
            double discriminant = Math.Pow(numberB, 2) - 4 * numberA * numberC;
            return discriminant;
        }
        public static double CalculateRootOne(double numberA, double numberB, double discriminant)
        {
            if (numberA == 0)
            {
                throw new DivideByZeroException("number A must not be 0");
            }
            double rootOne = (-1 * numberB - Math.Sqrt(discriminant)) / (2 * numberA);
            return rootOne;
        }
        public static double CalculateRootTwo(double numberA, double numberB, double discriminant)
        {
            if (numberA == 0)
            {
                throw new DivideByZeroException("number A must not be 0");
            }
            double rootTwo = (-1 * numberB + Math.Sqrt(discriminant)) / (2 * numberA);
            return rootTwo;
        }
        public static string ConvertNumberToString(int number)
        {
            string result;
            result = number switch
            {
                10 => "Ten",
                11 => "Eleven",
                12 => "Twelve",
                13 => "Thirteen",
                14 => "Fourteen",
                15 => "Fifteen",
                16 => "Sixteen",
                17 => "Seventeen",
                18 => "Eighteen",
                19 => "Nineteen",
                _ => "Number is not from 10 to 99",
            };
            int ten = number / 10;
            int one = number % 10;
            string ones = "";
            string tens = "";
            tens = ten switch
            {
                2 => "Twenty",
                3 => "Thirty",
                4 => "Fourty",
                5 => "Fifty",
                6 => "Sixty",
                7 => "Seventy",
                8 => "Eighty",
                9 => "Ninety",
                _ => "",
            };
            ones = one switch
            {
                1 => " one",
                2 => " two",
                3 => " three",
                4 => " four",
                5 => " five",
                6 => " six",
                7 => " seven",
                8 => " eight",
                9 => " nine",
                _ => "",
            };
            if (number > 19 && number < 100)
            {
                result = $"{tens} {ones}";
            }
            return result;
        }
    }
}
