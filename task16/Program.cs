/*

Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

*/

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber * firstNumber == secondNumber) {
    Console.WriteLine("Первое число является квадратом второго.");
} else if (secondNumber * secondNumber == firstNumber) {
    Console.WriteLine("Второе число является квадратом первого.");
} else {
    Console.WriteLine("Ни одно число не является квадратом другого.");
}