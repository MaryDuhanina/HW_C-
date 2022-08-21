//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N = 1;
bool not = true;
Console.WriteLine("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Чётные числа от 1 до " + numberA);
while (N <= numberA)
{
if (N % 2 == 0)
{
    Console.Write(N + ", ");
    not = false;
}
    int v = N++;
}
if (not)
{
Console.WriteLine("Нет чётных чисел!");
}