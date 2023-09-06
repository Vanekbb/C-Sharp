/*

Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет

*/

Console.Write("Укажите количество рядов: ");
int userColNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите количество строк: ");
int userRowNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите минимальное значение для заполнения: ");
int userNumberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное значение для заполнения: ");
int userNumberMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите позицию ряда елемента: ");
int userColElement = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите позицию строки елемента: ");
int userRowElement = Convert.ToInt32(Console.ReadLine());

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

void FindElementOnArray(int[,] array, int userRowValue, int userColValue) {
    int sizeArrayRows = array.GetLength(0);
    int sizeArrayCols = array.GetLength(1);

    if (userRowValue <= sizeArrayRows && userColValue <= sizeArrayCols) {
        Console.WriteLine($"Элемент на позициях {userRowValue},{userColValue} -> {array[userRowValue, userColValue]}");
    } else {
        Console.WriteLine($"{userRowValue},{userColValue} -> Такой позиции в массиве нет");
    }
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
Console.WriteLine();
FindElementOnArray(user2DArray, userRowElement, userColElement);