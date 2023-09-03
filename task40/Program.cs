/*

Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

*/

Console.WriteLine("Укажите 3 стороны треугольника: ");

int[] GetArray() {
    int[] array = new int[3];

    for (int i = 0; i < array.Length; i++) {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void TriangleCheck(int[] array) {
    if (array[0] < array[1] + array[2] && array[1] < array[0] + array[2] && array[2] < array[0] + array[1]) {
    Console.Write($"Треугольник со сторонами {array[0]}, {array[1]} и основанием {array[2]} может существовать");
} else {
    Console.Write($"Треугольник со сторонами {array[0]}, {array[1]} и основанием {array[2]} существовать не может");
    }
}

int[] userArray = GetArray();
TriangleCheck(userArray);