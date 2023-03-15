// 3. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

void div(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine("no");
}

Console.WriteLine("Enter number a");
int a = Convert.ToInt32(Console.ReadLine());

div(a);