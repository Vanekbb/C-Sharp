/*

Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10

*/

Console.Write("Укажите какое количество чисел хотите ввести: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string Delenie(int number) {
    string result = string.Empty;
    int temporary = 0;

    for (int i = number; i > 0; i /= 2) {
        temporary = i % 2;
        result += temporary;
    }

    return result;
}

Console.Write($"Число {userNumber} из десятичной в двоичную систему будет равен: {Delenie(userNumber)}");