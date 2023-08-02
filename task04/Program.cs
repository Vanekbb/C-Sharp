/*

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Введите первое число: ");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");

int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (max < SecondNumber) {
    max = SecondNumber;
}

if (max < ThirdNumber) {
    max = ThirdNumber;
}

Console.WriteLine("Максимально число из трех это: " + max);