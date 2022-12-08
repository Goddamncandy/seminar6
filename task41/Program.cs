// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементы массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
int [] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

for (int a = 0; a < array.Length; a++)
{
    if (array[a] > 0) count++;
}

Console.WriteLine($"Количество элементов больше нуля равно " + count);