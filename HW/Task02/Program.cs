Console.WriteLine ("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine (numberA + " max");
    Console.WriteLine (numberB + " min");
}
else
{
  Console.WriteLine (numberA + " min");
    Console.WriteLine (numberB + " max");  
}
if (numberA == numberB)
{
    Console.WriteLine ("Числа равны");
}

