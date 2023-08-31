/*

Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

*/

Console.Write("Укажите длинну массива: ");
int userNumberLength = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int userLength) {
    int[] array = new int[userLength];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000);
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

int ParityCheck(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            result++;
        }
    }
    return result;
}

int[] userArray = GetRandomArray(userNumberLength);
PrintArray(userArray);
Console.WriteLine($"Количество четных числе в массиве: {ParityCheck(userArray)}");