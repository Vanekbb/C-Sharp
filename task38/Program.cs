/*

Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

*/

double[] GetRandomArray() {
    int rnd = new Random().Next(1, 11);
    double[] array = new double[rnd];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(1, 101) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

double DifferenceMinMax (double[] array) {
    double min = array[0];
    double max = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        } else if (array[i] < min) {
            min = array[i];
        }
    }
    return max - min;
}

double[] userArray = GetRandomArray();
PrintArray(userArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DifferenceMinMax(userArray)}");