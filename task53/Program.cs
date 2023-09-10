﻿/*

Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2

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

int[,] Result2DArray(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int temporary = 0;

    for (int i = 0; i < cols; i++) {
        temporary = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temporary;
    }
    return array;
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
Console.WriteLine();
Print2DArray(Result2DArray(user2DArray));