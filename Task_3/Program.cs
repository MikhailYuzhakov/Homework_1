/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0) {
    Console.Write("Число "); Console.Write(a);
    Console.WriteLine(" является четныем");
} else {
    Console.Write("Число "); Console.Write(a);
    Console.WriteLine(" является нечетныем");
}
