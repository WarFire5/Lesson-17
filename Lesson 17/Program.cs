using Lesson_17;

Console.WriteLine();
Console.Write("Укажите количество элементов массива: ");
int aae = Calculator.ReadFromConsoleAmountOfArrayElements(); //aae - amount of array elements
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Задайте значения элементов массива: ");
Console.WriteLine();
int[] array = Calculator.ReadFromConsoleArray(aae);
Console.WriteLine();
Calculator.WriteTheEntireArray(array);
Console.WriteLine();
Console.WriteLine();

//1) Найти минимальный элемент массива.
Console.WriteLine();
Console.WriteLine("1. Нахождение минимального элемента массива.");
int min = Calculator.FindMinElementOfArray(array);
Calculator.WriteMinElementOfArray(min);
Console.WriteLine();

//2) Найти максимальный элемент массива.
Console.WriteLine();
Console.WriteLine("2. Нахождение максимального элемента массива.");
int max = Calculator.FindMaxElementOfArray(array);
Calculator.WriteMaxElementOfArray(max);
Console.WriteLine();

//3) Найти индекс минимального элемента массива.
Console.WriteLine();
Console.WriteLine("3. Нахождение индекса минимального элемента массива.");
int minIndex = Calculator.FindMinIndex(array);
Calculator.WriteMinIndexOfArray(minIndex);
Console.WriteLine();

//4) Найти индекс максимального элемента массива.
Console.WriteLine();
Console.WriteLine("4. Нахождение индекса максимального элемента массива.");
int maxIndex = Calculator.FindMaxIndex(array);
Calculator.WriteMaxIndexOfArray(maxIndex);
Console.WriteLine();

//5) Посчитать сумму элементов массива с нечетными индексами.
Console.WriteLine();
Console.WriteLine("5. Нахождение суммы элементов массива с нечётными индексами.");
int sum = Calculator.FindSum(array);
Calculator.WriteSum(sum);
Console.WriteLine();

//7) Посчитать количество нечетных элементов массива.
Console.WriteLine();
Console.WriteLine("7. Нахождение количества нечётных элементов массива и нечётных индексов массива.");
int sumOddElements = Calculator.FindSumOddElements(array);
Calculator.WriteSumOddElements(sumOddElements);
Console.WriteLine();
int sumOddIndex = Calculator.FindSumOddIndex(array);
Calculator.WriteSumOddIndex(sumOddIndex);
Console.WriteLine();

//8) Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
Console.WriteLine();
Console.WriteLine("8. Перестановка половин массива.");
int[] swapHalves = Calculator.SwapHalves(array);
Calculator.WriteSwapHalves(swapHalves);
Console.WriteLine();

//6) Сделать реверс массива (массив в обратном направлении).
Console.WriteLine();
Console.WriteLine("6. Создание обратного массива.");
int[] reverse = Calculator.Reverse(array);
Calculator.WriteReverse(reverse);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Конец!");