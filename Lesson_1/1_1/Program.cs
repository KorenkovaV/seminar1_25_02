// 1. Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("enter a number 1");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("enter a number 2");
int b = int.Parse(Console.ReadLine()!);

int c = b * b;

if (a == c)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}