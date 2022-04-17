/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Clear();
Console.WriteLine("Введите 3 числа для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число = ");
Console.WriteLine(max);
