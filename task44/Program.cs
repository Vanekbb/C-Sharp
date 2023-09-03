/*

Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/

Console.Write("Укажите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int number) {
    int[] fibonacciArray = new int[number];
    fibonacciArray[0] = 0;
    fibonacciArray[1] = 1;
    Console.Write("[");
    Console.Write($"{fibonacciArray[0]} ");
    Console.Write($"{fibonacciArray[1]} ");

    for (int i = 2; i < number; i++) {
        Console.Write($"{fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2]} ");
    }
    Console.Write("]");
}

Fibonacci(userNumber);