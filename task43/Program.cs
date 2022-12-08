// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2)/(k2 - k1);
    double y = (k2 * b1 - k1 * b2)/(k2 - k1);
    if (k1 == k2) Console.WriteLine("Прямые не пересекаются");
    else Console.WriteLine($"Точка пересечения прямых: ({x} {y})");
}

Console.Write("Введите координату b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

CrossPoint(b1, k1, b2, k2);