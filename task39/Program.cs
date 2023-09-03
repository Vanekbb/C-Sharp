/*

Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

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

void Revers(int[] array) {
    int temporary = 0;

    for (int i = 0; i < array.Length / 2; i++) {
        temporary = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temporary;
    }
}

int[] userArray = GetRandomArray(userNumberLength, userNumberMin, userNumberMax);
Console.ForegroundColor=ConsoleColor.DarkBlue;
PrintArray(userArray);
Revers(userArray);
Console.ForegroundColor=ConsoleColor.DarkRed;
PrintArray(userArray);