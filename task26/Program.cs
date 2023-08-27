/*

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5

*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int QuantityNumbers(int number) {
    int quantity = 0;

    if (number < 0) {
        number = number * -1;
    }

    if (number == 0) {
        quantity = 1;
        return quantity;
    }

    while(number > 0) {
        number = number / 10;
        quantity++;
    }
    return quantity;
}

Console.WriteLine(QuantityNumbers(userNumber));