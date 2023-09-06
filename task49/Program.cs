﻿/*

Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

int[,] Double2DArray(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] result = new int[rows, cols];

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (i % 2 == 0 && j % 2 == 0) {
            result[i, j] = array[i, j] * array[i, j];
            } else {
                result[i, j] = array[i, j];
            }
        }
    }
    return result;
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
Console.WriteLine();
int[,] userDouble2DArray = Double2DArray(user2DArray);
Print2DArray(userDouble2DArray);