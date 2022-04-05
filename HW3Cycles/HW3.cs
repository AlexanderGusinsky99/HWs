using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    static class HW3
    {
        public static void SolveTask1()
        {
            Console.WriteLine("\nHW3 CYCLES");
            Console.WriteLine("\nEx1");
            double numberA = Helpers.GetNumberFromUser("a");
            double numberB = Helpers.GetNumberFromUser("b");
            double result = PowByCycle(numberA, numberB);
            Console.WriteLine(result);
        }
        public static void SolveTask2()
        {
            Console.WriteLine("\nEx2");
            double number = Helpers.GetNumberFromUser("a");
            string result = GetAllGoodDividedNumbers(number);
            Console.WriteLine(result);
        }
        public static void SolveTask3()
        {
            Console.WriteLine("\nEx3");
            double numberA = Helpers.GetNumberFromUser("a");
            int amount = GetAmountOfSquaresSmallerThanNumber(numberA);
            Console.WriteLine(amount);
        }
        public static void SolveTask4()
        {
            Console.WriteLine("\nEx4");
            double number = Helpers.GetNumberFromUser("a");
            double nd = CalculateNDOfNumber(number);
            Console.WriteLine(nd);
        }
        public static void SolveTask5()
        {
            Console.WriteLine("\nEx5");
            double numberA = Helpers.GetNumberFromUser("a");
            double numberB = Helpers.GetNumberFromUser("b");
            double sum = GetSumOfNumbersDividedBySeven(numberA, numberB);
            Console.WriteLine(sum);
        }
        public static void SolveTask6()
        {
            Console.WriteLine("\nEx6");
            double valueN = Helpers.GetNumberFromUser("n");
            int fibonachiN = 1;
            int previous1 = 0;
            int previous2 = 1;
            for (int i = 1; i < valueN; i++)
            {
                fibonachiN = previous1 + previous2;
                previous1 = previous2;
                previous2 = fibonachiN;
            }
            Console.WriteLine(fibonachiN);
        }
        public static void SolveTask7()
        {
            Console.WriteLine("\nEx7");
            double evklidA = Helpers.GetNumberFromUser("a");
            double evklidB = Helpers.GetNumberFromUser("b");
            double nod;
            double tmpEvklid;
            if (evklidA > evklidB)
            {
                while (evklidA != evklidB)
                {
                    evklidA = evklidA - evklidB;
                    if (evklidA < evklidB)
                    {
                        tmpEvklid = evklidB;
                        evklidB = evklidA;
                        evklidA = tmpEvklid;
                    }
                }
                nod = evklidB;
            }
            else if (evklidA < evklidB)
            {
                while (evklidA != evklidB)
                {
                    evklidB = evklidB - evklidA;
                    if (evklidB < evklidA)
                    {
                        tmpEvklid = evklidB;
                        evklidB = evklidA;
                        evklidA = tmpEvklid;
                    }
                }
                nod = evklidB;
            }
            else
            {
                nod = evklidA;
            }
            Console.WriteLine(nod);
        }
        public static void SolveTask8()
        {
            Console.WriteLine("\nEx8");
            double cubeN = Helpers.GetNumberFromUser("n");
            double left = 0;
            double mid = 0;
            double right = cubeN;

            while (Math.Pow(mid, 3) != cubeN)
            {
                if (left < right)
                {
                    mid = (left + right) / 2;
                    if (Math.Pow(mid, 3) > cubeN)
                    { right = mid; }
                    else if (Math.Pow(mid, 3) < cubeN)
                    { left = mid; }
                }
                else if (left > right)
                {
                    mid = left;
                    mid = (mid + right) / 2;
                }
            }
            Console.WriteLine(mid);
        }
        public static void SolveTask9()
        {
            Console.WriteLine("\nEx9");
            double a = Helpers.GetNumberFromUser("a");
            double count = 0;
            double tmp = 0;
            while (a > 0)
            {
                tmp = a % 10;
                if (tmp % 2 != 0)
                {
                    count += 1;
                }
                a /= 10;
            }
            Console.WriteLine(count);
        }
        public static void SolveTask10()
        {
            Console.WriteLine("\nEx10");
            double input = Helpers.GetNumberFromUser("a");
            double number = 0;
            while (input > 0)
            {
                number = number * 10 + input % 10;
                input = input / 10;
            }
            Console.WriteLine(number);
        }
        public static void SolveTask11()
        {
            Console.WriteLine("\nEx11");
            double n = Helpers.GetNumberFromUser("n");
            double sumOfEven = 0;
            double sumOfUneven = 0;
            double tmp1;
            double tmp2;
            for (int i = 1; i <= n; i++)
            {
                tmp2 = i;
                while (tmp2 > 0)
                {
                    tmp1 = tmp2 % 10;
                    if (tmp1 % 2 == 0)
                    {
                        sumOfEven += tmp1;
                    }
                    else
                    {
                        sumOfUneven += tmp1;
                    }
                    tmp2 = tmp2 / 10;
                }
                if (sumOfEven > sumOfUneven)
                {
                    Console.WriteLine(i);
                    sumOfEven = 0;
                    sumOfUneven = 0;
                }
                else
                {
                    sumOfEven = 0;
                    sumOfUneven = 0;
                }
                Console.WriteLine($"{sumOfEven}, {sumOfUneven}");
            }
        }
        public static void SolveTask12()
        {
            Console.WriteLine("\nEx12");
            double numberA = Helpers.GetNumberFromUser("a");
            double numberB = Helpers.GetNumberFromUser("b");
            bool isSameValue = false;
            double tmpAAA = 0;
            double tmpBBB;
            double temporaryA = 0;
            if (numberA > 0)
            {
                temporaryA = numberA;
                while (temporaryA > 0)
                {
                    tmpAAA = numberA % 10;
                    while (numberB > 0)
                    {
                        tmpBBB = numberB % 10;
                        if (tmpAAA == tmpBBB)
                        {
                            isSameValue = true;
                        }
                        numberB = numberB / 10;
                    }
                    temporaryA = temporaryA / 10;
                }
            }
            string result;
            if (isSameValue)
            { result = "yes"; }
            else
            { result = "no"; }
            Console.WriteLine(result);
        }
        public static double PowByCycle(double numberA, double numberB)
        {
            double result = 1d;
            for (int i = 0; i < numberB; i++)
            {
                result *= numberA;
            }
            return result;
        }
        public static string GetAllGoodDividedNumbers(double numberA)
        {
            string result = "";
            for (double i = numberA; i <= 1000; i += numberA)
            {
                result += $"{i}  ";
            }
            return result;
        }
        public static int GetAmountOfSquaresSmallerThanNumber(double numberA)
        {
            int amount = 0;
            for (int i = 1; i < numberA; i++)
            {
                if (i * i < numberA)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static double CalculateNDOfNumber(double numberA)
        {
            double nd = 1;
            for (int i = 1; i < numberA; i++)
            {
                if (numberA % i == 0)
                {
                    nd = i;
                }
            }
            return nd;
        }
        public static double GetSumOfNumbersDividedBySeven(double numberA, double numberB)
        {
            double sum = 0;
            if (numberA < numberB)
            {
                for (double i = numberA; i <= numberB; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            else if (numberA > numberB)
            {
                for (double i = numberB; i <= numberA; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}

