namespace Lesson_17
{
    public static class Calculator
    {
        //1) Найти минимальный элемент массива.
        public static int ReadFromConsoleAmountOfArrayElements()
        {
            int aae = Convert.ToInt32(Console.ReadLine()); //aae - amount of array elements
            if (aae <= 0)
            {
                while (aae <= 0)
                {
                    Console.WriteLine(";");
                    Console.Write("Число элементов масива должно быть больше 0. Задайте корректное значение: ");
                    aae = Convert.ToInt32(Console.ReadLine());
                }
            }
            return aae;
        }
        public static int[] ReadFromConsoleArray(int aae)
        {
            int[] array = new int[aae];
            for (int i = 0; i < aae; i++)
            {
                Console.Write($"Присвойте {i}-ому элементу значение: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(";");
            }
            return array;
        }
        public static void WriteTheEntireArray(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{i}-ому элементу ");
                Console.Write($"соответствует значение {array[i]};");
                Console.WriteLine();
            }
        }
        public static int FindMinElementOfArray(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        public static void WriteMinElementOfArray(int min)
        {
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива: {min}.");
            Console.WriteLine();
        }

        //2) Найти максимальный элемент массива.
        public static int FindMaxElementOfArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        public static void WriteMaxElementOfArray(int max)
        {
            Console.WriteLine();
            Console.WriteLine($"Максимальный элемент массива: {max}.");
            Console.WriteLine();
        }

        //3) Найти индекс минимального элемента массива.
        public static int FindMinIndex(int[] array)
        {
            int minIndex = 0;
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        public static void WriteMinIndexOfArray(int minIndex)
        {
            Console.WriteLine();
            Console.WriteLine($"Индекс минимального элемента массива: {minIndex}.");
            Console.WriteLine();
        }

        //4) Найти индекс максимального элемента массива.
        public static int FindMaxIndex(int[] array)
        {
            int maxIndex = 0;
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        public static void WriteMaxIndexOfArray(int maxIndex)
        {
            Console.WriteLine();
            Console.WriteLine($"Индекс максимального элемента массива: {maxIndex}.");
            Console.WriteLine();
        }

        //5) Посчитать сумму элементов массива с нечетными индексами.
        public static int FindSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static void WriteSum(int sum)
        {
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов массива с нечётными индексами: {sum}.");
            Console.WriteLine();
        }

        //6) Сделать реверс массива(массив в обратном направлении).
        public static int[] Reverse(int[] array)
        {
            int[] reverse = new int[array.Length];
            int tmp = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverse[tmp] = array[i];
                tmp++;
            }
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = reverse[j];
            }
            return array;
        }
        public static void WriteReverse(int[] reverse)
        {
            Console.WriteLine();
            Console.WriteLine("Зеркальное отображение введённого массива: ");
            for (int j = 0; j < reverse.Length; j++)
            {
                Console.WriteLine(reverse[j]);
            }
            Console.WriteLine();
        }

        //7) Посчитать количество нечетных элементов массива.
        public static int FindSumOddElements(int[] array)
        {
            int sumOddElements = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sumOddElements++;
                }
            }
            return sumOddElements;
        }
        public static void WriteSumOddElements(int sumOddElements)
        {
            Console.WriteLine();
            Console.WriteLine($"Количество нечётных элементов массива: {sumOddElements}.");
        }
        public static int FindSumOddIndex(int[] arrayOdd)
        {
            int sumOddIndex = 0;
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumOddIndex++;
                }
            }
            return sumOddIndex;
        }
        public static void WriteSumOddIndex(int sumOddIndex)
        {
            Console.WriteLine($"Количество нечётных индексов массива: {sumOddIndex}.");
            Console.WriteLine();
        }

        //8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.        
        public static int[] SwapHalves(int[] array)
        {
            int tmp = 0;
            int[] swapHalves = new int[array.Length];
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                swapHalves[tmp] = array[i];
                tmp++;
            }
            for (int j = 0; j < array.Length / 2; j++)
            {
                swapHalves[tmp] = array[j];
                tmp++;
            }
            array = swapHalves;
            return array;
        }
        public static void WriteSwapHalves(int[] swapHalves)
        {
            Console.WriteLine();
            Console.WriteLine("Массив с поменянными местами половинами: ");
            for (int j = 0; j < swapHalves.Length; j++)
            {
                Console.WriteLine(swapHalves[j]);
            }
            Console.WriteLine();
        }
    }
}
