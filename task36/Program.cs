/*

Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

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

int SumOddPosition(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
            result += array[i];
        }
    }
    return result;
}

int[] userArray = GetRandomArray(userNumberLength, userNumberMin, userNumberMax);
PrintArray(userArray);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {SumOddPosition(userArray)}");