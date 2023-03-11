
// в конце после объявления функции ; не ставится

int big(int rand)
{
    Console.WriteLine(rand);
    int a = (rand - rand % 10) / 10;
    int b = rand % 10;
    if (a > b) return a;
    else return b;
}
int result = big(new Random().Next(10, 100));
Console.WriteLine(result);
