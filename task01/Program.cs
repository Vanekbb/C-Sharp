/* Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> Является.
a = 2; b = 10 -> Не является.

*/

Console.WriteLine("Введите первое число: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int SecondNumber = Convert.ToInt32(Console.ReadLine());

int resultSecondNumber = SecondNumber * SecondNumber;

if (firstNumber == resultSecondNumber) {
    Console.WriteLine("Первое число является квадратом второго.");
} else {
    Console.WriteLine("Первое число не является квадратом второго.");
};
