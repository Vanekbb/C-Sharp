/*

Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

*/

Console.Write("Укажите длинну массива: ");
int userNumberLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите минимальное значение для заполнения: ");
int userNumberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное значение для заполнения: ");
int userNumberMax = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int userLength, int userMin, int userMax) {
    int[] array = new int[userLength];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(userMin, userMax + 1);
    }
    return array;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] array) {
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++) {
        copyArray[i] = array[i];
    }
    return copyArray;
}

int[] userArray = GetRandomArray(userNumberLength, userNumberMin, userNumberMax);
PrintArray(userArray);
PrintArray(CopyArray(userArray));