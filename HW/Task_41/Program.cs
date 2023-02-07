/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[] array = new double[n];
int i = 0;
for (i = 0; i < n; i++)
{
    Console.WriteLine("Введите элемент массива: ");
    array[i] = double.Parse(Console.ReadLine());
    Console.WriteLine();
}

for (i = 0; i < n; i++)
{
    Console.WriteLine($"Элемент [{i}]: {array[i]}");
}

int count = 0;
Console.Write($"Положительные элементы: ");
for (i = 0; i < n; i++)
{
    if (array[i] > 0) 
    {
       
       Console.Write($"{array[i]}, ");
       
       count++; 
    }
}
Console.Write("\b\b ");
Console.WriteLine($" Количество элементов больше нуля равно: {count}");
