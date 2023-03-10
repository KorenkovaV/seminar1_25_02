/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Enter a positive number: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (a == 1)
{
    Console.WriteLine("There are no even numbers between");
}
else
{
    while (a >= count)
    {
        Console.Write($"{count} ");
        count = count + 2;
    }
}

