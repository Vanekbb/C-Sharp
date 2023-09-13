/*

Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии

*/

int AToTheDegreeOfB(int a, int b) {
    if (b == 1) {
        return a;
    } else {
        return a * AToTheDegreeOfB(a, b - 1);
    }
}

int result = AToTheDegreeOfB(5, 3);

Console.Write(result);