/*

Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

*/

Console.Write("Укажите длинну массива: ");
int userNumberLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите минимальное значение для заполнения: ");
int userNumberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное значение для заполнения: ");
int userNumberMax = Convert.ToInt32(Console.ReadLine());

Console.Write("Число для проверки на присутствие в массиве: ");
int userNumberChecked = Convert.ToInt32(Console.ReadLine());

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

void CheckTheNumber(int checkedNumber, int[] array) {
    int result = 0;
    
    for (int i = 0; i < array.Length; i++) {
        if (array[i] == checkedNumber) {
            result++;
        }
    }
    if (result > 0) {
        Console.WriteLine($"Число {checkedNumber} встречается в массиве {result} раз.");
    } else {
        Console.WriteLine($"Число {checkedNumber} отсутствует в массиве.");
    }
}

int[] userArray = GetRandomArray(userNumberLength, userNumberMin, userNumberMax);
PrintArray(userArray);
CheckTheNumber(userNumberChecked, userArray);