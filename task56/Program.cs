/*

Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/

Console.Write("Укажите количество колонок: ");
int userColNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите количество строк: ");
int userRowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите минимальное значение для заполнения: ");
int userNumberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное значение для заполнения: ");
int userNumberMax = Convert.ToInt32(Console.ReadLine());

int[,] GetRandom2DArray(int rowNumber, int colNumber, int userMinValue, int userMaxValue) {
    int[,] result = new int[rowNumber, colNumber];

    for (int i = 0; i < rowNumber; i++) {
        for (int j = 0; j < colNumber; j++) {
            result[i,j] = new Random().Next(userMinValue, userMaxValue + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] array) {
    Console.Write($"[№]\t");
    for (int i = 0; i < array.GetLength(1); i++) {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++) {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        if (i == array.Length - 1) {
        Console.Write($"{array[i]}");
        } else {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine("]");
}

int[] SumNumbersOnRows(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] sumsArray = new int[rows];
    int index = 0;

    for (int i = 0; i < rows; i++) {
        int sum = 0;
        for (int j = 0; j < cols; j++) {
            sum += array[i, j];
        }
        sumsArray[index] = sum;
        index++;
    }
    return sumsArray;
}

int FindMinNumberOnArray(int[] array) {
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

void FindMinRowsSum(int[] array, int min) {
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == min) {
            Console.WriteLine($"Минимальная сумма чисел в строке: {i + 1}");
        }
    }
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
int[] userArray = SumNumbersOnRows(user2DArray);
PrintArray(userArray);
int minNumber = FindMinNumberOnArray(userArray);
FindMinRowsSum(userArray, minNumber);