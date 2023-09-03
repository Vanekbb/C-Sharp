/*

Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3

*/

Console.Write("Укажите какое количество чисел хотите ввести: ");
int userNumberLength = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int userLength) {
    int[] array = new int[userLength];

    for (int i = 0; i < array.Length; i++) {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int ZeroCount(int[] array) {
    int count = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            count++;
        }
    }
    return count;
}

int[] userArray = GetRandomArray(userNumberLength);
PrintArray(userArray);
Console.Write($"Количество чисел больше 0: {ZeroCount(userArray)}");