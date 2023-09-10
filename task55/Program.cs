/*

Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

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

int[,] ChangeRowsAndColums(int[,] array) {
    int temporary = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = i; j < array.GetLength(1); j++) {
            temporary = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temporary;
        }
    }
    return array;
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
Console.WriteLine();
Print2DArray(ChangeRowsAndColums(user2DArray));