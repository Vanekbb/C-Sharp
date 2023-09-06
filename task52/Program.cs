/*

Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

*/

Console.Write("Укажите количество рядов: ");
int userColNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите количество строк: ");
int userRowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите минимальное значение для заполнения: ");
int userNumberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное значение для заполнения: ");
int userNumberMax = Convert.ToInt32(Console.ReadLine());

int[,] GetRandom2DArray(int colNumber, int rowNumber, int userMinValue, int userMaxValue) {
    int[,] result = new int[rowNumber,colNumber];

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

void ArithmeticMeanOnArray(int[,] array) {
    Console.Write($"[AM]\t");
    for (int j = 0; j < array.GetLength(1); j++) {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++) {
            sum += array[i, j];
        }
            double arithmeticMean = Math.Round(sum / array.GetLength(0), 1);
            Console.Write($"{arithmeticMean}\t");
    }
    }

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
ArithmeticMeanOnArray(user2DArray);