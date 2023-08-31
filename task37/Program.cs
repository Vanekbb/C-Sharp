/*

Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

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

void Composition(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array.Length - 1 > 2) {
        result = array[i] * array[array.Length - 1];
        Console.Write($"{result} ");
        array = array.SkipLast(1).ToArray();
        } else {
            Console.Write($"{array[i]} ");
        }
    }
}

int[] userArray = GetRandomArray(userNumberLength, userNumberMin, userNumberMax);
PrintArray(userArray);
Composition(userArray);