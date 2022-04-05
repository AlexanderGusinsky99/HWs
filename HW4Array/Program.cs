using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    static class HW4
    {
        public static void SolveTaskOne()
        {
            Console.WriteLine("\nEx1");
            Random random = new Random();
            int[] arrayToFindMinItem = new int[10];
            for (int i = 0; i < arrayToFindMinItem.Length; i++)
            {
                arrayToFindMinItem[i] = random.Next(-50, 51);
            }
            int minItem = arrayToFindMinItem[0];
            for (int i = 0; i < arrayToFindMinItem.Length; i++)
            {
                if (minItem > arrayToFindMinItem[i])
                {
                    minItem = arrayToFindMinItem[i];
                }
                Console.Write(arrayToFindMinItem[i] + " ");
            }
            Console.WriteLine($"\n{minItem}");
        }
        public static void SolveTaskTwo()
        {
            Console.WriteLine("\nEx2");
            Random random = new Random();
            int[] arrayToFindMaxItem = new int[10];
            for (int i = 0; i < arrayToFindMaxItem.Length; i++)
            {
                arrayToFindMaxItem[i] = random.Next(-50, 51);
            }
            int maxItem = arrayToFindMaxItem[0];
            for (int i = 0; i < arrayToFindMaxItem.Length; i++)
            {
                if (maxItem < arrayToFindMaxItem[i])
                {
                    maxItem = arrayToFindMaxItem[i];
                }
                Console.Write(arrayToFindMaxItem[i] + " ");
            }
            Console.WriteLine($"\n{maxItem}");
        }
        public static void SolveTaskThree()
        {
            Console.WriteLine("\nEx3");
            Random random = new Random();
            int[] arrayToFindMinIndex = new int[10];
            for (int i = 0; i < arrayToFindMinIndex.Length; i++)
            {
                arrayToFindMinIndex[i] = random.Next(-50, 51);
            }
            int minIndex = 0;
            int tmpMinItem = arrayToFindMinIndex[0];
            for (int i = 0; i < arrayToFindMinIndex.Length; i++)
            {
                if (tmpMinItem > arrayToFindMinIndex[i])
                {
                    tmpMinItem = arrayToFindMinIndex[i];
                    minIndex = i;
                }
                Console.Write(arrayToFindMinIndex[i] + " ");
            }
            Console.WriteLine($"\n{minIndex}");
        }
        public static void SolveTaskFour()
        {
            Console.WriteLine("\nEx4");
            Random random = new Random();
            int[] arrayToFindMaxIndex = new int[10];
            for (int i = 0; i < arrayToFindMaxIndex.Length; i++)
            {
                arrayToFindMaxIndex[i] = random.Next(-50, 51);
            }
            int maxIndex4 = 0;
            int maxItem4 = arrayToFindMaxIndex[0];
            for (int i = 0; i < arrayToFindMaxIndex.Length; i++)
            {
                if (maxItem4 < arrayToFindMaxIndex[i])
                {
                    maxItem4 = arrayToFindMaxIndex[i];
                    maxIndex4 = i;
                }
                Console.Write(arrayToFindMaxIndex[i] + " ");
            }
            Console.WriteLine($"\n{maxIndex4}");
        }
        public static void SolveTaskFive()
        {
            Console.WriteLine("\nEx5");
            Random random = new Random();
            int[] arrayToFinSumOfElements = new int[4];
            for (int i = 0; i < arrayToFinSumOfElements.Length; i++)
            {
                arrayToFinSumOfElements[i] = random.Next(-50, 51);
            }
            int sumOfElements = 0;
            for (int i = 0; i < arrayToFinSumOfElements.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOfElements += arrayToFinSumOfElements[i];
                }
                Console.Write(arrayToFinSumOfElements[i] + " ");
            }
            Console.WriteLine($"\n{sumOfElements}");
        }
        public static void SolveTaskSix()
        {
            Console.WriteLine("\nEx6");
            Random random = new Random();
            int[] arrayForReverse = new int[10];
            for (int i = 0; i < arrayForReverse.Length; i++)
            {
                arrayForReverse[i] = random.Next(-50, 51);
            }
            for (int i = 0; i < arrayForReverse.Length; i++)
            {
                Console.Write(arrayForReverse[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayForReverse.Length / 2; i++)
            {
                int tmpReversed = arrayForReverse[i];
                arrayForReverse[i] = arrayForReverse[arrayForReverse.Length - i - 1];
                arrayForReverse[arrayForReverse.Length - i - 1] = tmpReversed;
            }
            for (int i = 0; i < arrayForReverse.Length; i++)
            {
                Console.Write(arrayForReverse[i] + " ");
            }
        }
        public static void SolveTaskSeven()
        {
            Console.WriteLine("\nEx7");
            Random random = new Random();
            int[] arrayForSum = new int[10];
            for (int i = 0; i < arrayForSum.Length; i++)
            {
                arrayForSum[i] = random.Next(-50, 51);
            }
            int amountOfItems = 0;
            for (int i = 0; i < arrayForSum.Length; i++)
            {
                if (arrayForSum[i] % 2 != 0)
                {
                    amountOfItems += 1;
                }
                Console.Write(arrayForSum[i] + " ");
            }
            Console.WriteLine($"\n{amountOfItems}");
        }
        public static void SolveTaskEight()
        {
            Console.WriteLine("\nEx8");
            Random random = new Random();
            int[] arrayReversed = new int[10];
            for (int i = 0; i < arrayReversed.Length; i++)
            {
                arrayReversed[i] = random.Next(-50, 51);
            }
            for (int i = 0; i < arrayReversed.Length; i++)
            {
                Console.Write(arrayReversed[i] + " ");
            }
            Console.WriteLine();
            int j1 = arrayReversed.Length / 2;
            int tmpOddArray = 0;
            int tmpForEhth = 0;
            if (arrayReversed.Length % 2 != 0)
            {
                tmpOddArray = 1;
            }
            for (int i = 0; i < j1; i++)
            {
                tmpForEhth = arrayReversed[i];
                arrayReversed[i] = arrayReversed[i + j1 + tmpOddArray];
                arrayReversed[i + j1 + tmpOddArray] = tmpForEhth;

            }
            for (int i = 0; i < arrayReversed.Length; i++)
            {
                Console.Write(arrayReversed[i] + " ");
            }
        }
        public static void SolveTaskNine()
        {
            Console.WriteLine("\nEx9");
            Random random = new Random();
            int[] arraySorted = new int[10];
            for (int i = 0; i < arraySorted.Length; i++)
            {
                arraySorted[i] = random.Next(-50, 50);
            }
            for (int i = 0; i < arraySorted.Length; i++)
            {
                Console.Write(arraySorted[i] + " ");
            }
            Console.WriteLine();
            int tmpArraySorted = arraySorted[0];
            for (int i = 0; i < arraySorted.Length - 1; i++)
            {
                for (int j = 0; j < arraySorted.Length - i - 1; j++)
                {
                    if (arraySorted[j + 1] < arraySorted[j])
                    {
                        tmpArraySorted = arraySorted[j + 1];
                        arraySorted[j + 1] = arraySorted[j];
                        arraySorted[j] = tmpArraySorted;
                    }
                }
            }
            for (int i = 0; i < arraySorted.Length; i++)
            {
                Console.Write(arraySorted[i] + " ");
            }
        }
        public static void SolveTaskTen()
        {
            Console.WriteLine("\nEx10");
            Random random = new Random();
            int[] arrayToSort = new int[10];
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                arrayToSort[i] = random.Next(-50, 50);
            }
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < arrayToSort.Length; i++)
            {
                int tmp = arrayToSort[i];
                int j = i;
                while (j > 0 && tmp < arrayToSort[j - 1])
                {
                    arrayToSort[j] = arrayToSort[j - 1];
                    j--;
                }
                arrayToSort[j] = tmp;
            }
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i] + " ");
            }
        }
    }
}
