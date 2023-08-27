/*

Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNumber(int userNumber) {
    int sum = 0;

    for (int i = 1; i <= userNumber; i++) {
    sum += i;
}
    return sum;
}

Console.WriteLine(SumOfNumber(number));