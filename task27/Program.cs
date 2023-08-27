/*

Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int number) {
    int temporary = 0;
    int sum = 0;

    while (number > 0) {
        temporary = number % 10;
        sum += temporary;
        number = number / 10;
    }
    return sum;
}

Console.WriteLine(SumOfDigits(userNumber));