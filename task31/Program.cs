/*

Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

*/

int[] GetRandomArray() {
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(-9, 10);
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

int SumPositive(int[] array) {
    int positive = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            positive = positive + array[i];
        }
    }
    return positive;
}

int SumNegative(int[] array) {
    int negative = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] < 0) {
            negative = negative + array[i];
        }
    }
    return negative;
}

int[] testArray = GetRandomArray();
PrintArray(testArray);
Console.WriteLine($"Сумма положительных чисел в массиве: {SumPositive(testArray)}");
Console.WriteLine($"Сумма отрицательных чисел в массиве: {SumNegative(testArray)}");