/*

Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

{ 1, 9, 9, 0, 2, 8, 0, 9 }

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

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

int[] ConvertToArray(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[] converArray = new int[rows * cols];
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            converArray[index] = array[i, j];
            index++;
        }
    }
    return converArray;
}

int FindMaxNumberOnArray(int[] array) {
    int max = array[0];

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max;
}

void Dictionary(int[] array, int maxNumber) {
    for (int i = 0; i < maxNumber + 1; i++) {
        int count = 0;

        for (int j = 0; j < array.Length; j++) {
            if (array[j] == i) {
                count++;
            }
        }
        if (count > 0) {
            Console.WriteLine($"{i} встречается {count} раз.");
        }
    }
}

int[,] user2DArray = GetRandom2DArray(userRowNumber, userColNumber, userNumberMin, userNumberMax);
Print2DArray(user2DArray);
int[] userArray = ConvertToArray(user2DArray);
PrintArray(userArray);
int maxNumberOnArray = FindMaxNumberOnArray(userArray);
Dictionary(userArray, maxNumberOnArray);