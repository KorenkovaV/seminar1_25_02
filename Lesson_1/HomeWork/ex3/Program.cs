﻿/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number % 2 == 0 )
{
    Console.WriteLine($"{number} is even numder");
}
else
{
    Console.WriteLine($"{number} is odd number");
}
