/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void third_num(int a)
{
    if (a < 100)
        Console.WriteLine("no third number");
    else
    {
            while (a > 999)
            a = a / 10;
            Console.WriteLine(a % 10);          
    }
}

Console.WriteLine("Enter a number");
int a = Convert.ToInt32(Console.ReadLine());

third_num(a);

//не поняла как быть с числами больше 2147483647