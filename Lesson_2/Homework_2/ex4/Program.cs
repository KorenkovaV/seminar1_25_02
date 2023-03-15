/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

void day(int a)
{
    if (a > 0 && a <= 5)
    {
        Console.WriteLine("no");
    }
    if (a == 6 || a == 7)
    {
        Console.WriteLine("yes");
    }
    if (a <= 0 || a > 7)
    {
        Console.WriteLine("it's not a weekday number");
    }
}

Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());

day(a);