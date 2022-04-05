using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryPoint
{
    public static class HW5
    {
        public static void SolveTaskOne()
        {
            Console.WriteLine("\nEx1");
            Random random = new Random();
            int[,] array = new int[2, 4];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            int minItem = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minItem > array[i, j])
                    {
                        minItem = array[i, j];
                    }
                }
            }
            Console.WriteLine($"\nРезультат: {minItem}");
        }
        public static void SolveTaskTwo()
        {
            Console.WriteLine("\nEx2");
            Random random = new Random();
            int[,] array = new int[2, 4];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            int maxItem = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxItem < array[i, j])
                    {
                        maxItem = array[i, j];
                    }
                }
            }
            Console.WriteLine(maxItem);
        }
        public static void SolveTaskThree()
        {
            Console.WriteLine("\nEx3");
            Random random = new Random();
            int[,] array = new int[2, 4];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            int[] minIndex = new int[] { 0, 0 };
            int minItemOfArray = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (minItemOfArray > array[i, j])
                    {
                        minItemOfArray = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                    }
                }
            }
            Console.WriteLine($"\n{minIndex[0]}, {minIndex[1]}");
        }
        //Найти индекс максимального элемента массива
        public static void SolveTaskFour()
        {
            Console.WriteLine("\nEx4");
            Random random = new Random();
            int[,] arrayToFindMaxIndex = new int[2, 4];
            for (int i = 0; i < arrayToFindMaxIndex.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindMaxIndex.GetLength(1); j++)
                {
                    arrayToFindMaxIndex[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < arrayToFindMaxIndex.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindMaxIndex.GetLength(1); j++)
                {
                    Console.Write($"{arrayToFindMaxIndex[i, j]}\t");
                }
                Console.WriteLine();
            }
            int[] maxIndex = new int[] { 0, 0 };
            int maxItemOfArray = arrayToFindMaxIndex[0, 0];
            for (int i = 0; i < arrayToFindMaxIndex.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindMaxIndex.GetLength(1); j++)
                {
                    if (maxItemOfArray < arrayToFindMaxIndex[i, j])
                    {
                        maxItemOfArray = arrayToFindMaxIndex[i, j];
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                }
            }
            Console.WriteLine($"{maxIndex[0]}, {maxIndex[1]}");
        }
        //Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static void SolveTaskFive()
        {
            Console.WriteLine("\nEx5");
            Random random = new Random();
            int[,] arrayToFindBiggerItem = new int[4, 4];
            for (int i = 0; i < arrayToFindBiggerItem.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindBiggerItem.GetLength(1); j++)
                {
                    arrayToFindBiggerItem[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < arrayToFindBiggerItem.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindBiggerItem.GetLength(1); j++)
                {
                    Console.Write($"{arrayToFindBiggerItem[i, j]}\t");
                }
                Console.WriteLine();
            }
            int counter = 0;
            int MaxI = arrayToFindBiggerItem.GetLength(0) - 1;
            int MaxJ = arrayToFindBiggerItem.GetLength(1) - 1;
            for (int i = 0; i < arrayToFindBiggerItem.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToFindBiggerItem.GetLength(1); j++)
                {
                    if (i == 0 && j == 0 && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1])
                    { counter += 1; }
                    else if (i == 0 && j == MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j])
                    { counter += 1; }
                    else if (i == MaxI && j == MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1])
                    { counter += 1; }
                    else if (i == MaxI && j == 0 && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1])
                    { counter += 1; }
                    else if (i > 0 && i < MaxI && j == 0 && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j] && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1])
                    { counter += 1; }
                    else if (i == 0 && j > 0 && j < MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1] && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j])
                    { counter += 1; }
                    else if (i > 0 && i < MaxI && j == MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j] && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1])
                    { counter += 1; }
                    else if (i == MaxI && j > 0 && j < MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1] && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j])
                    { counter += 1; }
                    else if (i > 0 && i < MaxI && j > 0 && j < MaxJ && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i + 1, j]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i - 1, j] && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j + 1]
                        && arrayToFindBiggerItem[i, j] > arrayToFindBiggerItem[i, j - 1])
                    { counter += 1; }
                }
            }
            Console.WriteLine($"Результат: {counter}");
        }
        //Отразите массив относительно его главной диагонали
        public static void SolveTaskSix()
        {
            Console.WriteLine("\nEx6");
            Random random = new Random();
            int[,] arrayReflected = new int[2, 4];
            for (int i = 0; i < arrayReflected.GetLength(0); i++)
            {
                for (int j = 0; j < arrayReflected.GetLength(1); j++)
                {
                    arrayReflected[i, j] = random.Next(-50, 51);
                }
            }
            for (int i = 0; i < arrayReflected.GetLength(0); i++)
            {
                for (int j = 0; j < arrayReflected.GetLength(1); j++)
                {
                    Console.Write($"{arrayReflected[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
