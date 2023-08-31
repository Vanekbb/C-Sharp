/*

Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123

[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

*/


int[] GetRandomArray() {
    int[] array = new int[123];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 1000);
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

int FoundTheGap(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 9 && array[i] < 100) {
            result++;
        }
    }
    return result;
}

int[] userArray = GetRandomArray();
PrintArray(userArray);
Console.WriteLine($"Количество чисел в массиве лежащих в промежутке [10, 99]: {FoundTheGap(userArray)}");