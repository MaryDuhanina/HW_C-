Console.WriteLine ("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите третье число ");
int numberC = Convert.ToInt32(Console.ReadLine ());
if (numberA > numberB || numberA > numberC)
{
    Console.WriteLine (numberA + " max");
}
if (numberB > numberC || numberB > numberA)
{
    Console.WriteLine (numberB + " max");
}
else
{
    Console.WriteLine (numberC + " max");
}
