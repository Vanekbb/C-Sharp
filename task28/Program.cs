/*

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120

*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int ProductOfNumbers(int number) {
    int result = 1;

    /*while (number > 0) {
        result *= number;
        number--;
    }*/
    
    for (int i = 1; i <= number; i++) {
        result *= i;
    }
    return result;
}

Console.WriteLine(ProductOfNumbers(userNumber));