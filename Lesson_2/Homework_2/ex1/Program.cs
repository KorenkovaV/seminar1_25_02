/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int sec_num(int num)
{
    Console.WriteLine(num);
    int a = num % 100;
    int b = a / 10;
    return b;
}

int result = sec_num(new Random().Next(100, 1000));
Console.WriteLine(result);