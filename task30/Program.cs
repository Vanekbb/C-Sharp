/*

Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

*/

int[] GetRandomArray() {
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array) {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
} 

int[] userArray = GetRandomArray();
PrintArray(userArray);