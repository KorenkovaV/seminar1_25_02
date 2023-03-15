// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void mult(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("multiple");
    else
        Console.WriteLine($"not multiple, remainder of division is {a % b}");
}

Console.WriteLine("Enter number a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number b");
int b = Convert.ToInt32(Console.ReadLine());

mult(a, b);
