﻿Console.WriteLine ("Введите цифру дня недели ");
int numberA = Convert.ToInt32(Console.ReadLine ());

if (numberA >7 || numberA < 1)
{
    Console.WriteLine ("Нет такого дня недели");
}

if (numberA == 1)
{
    Console.WriteLine ("Понедельник");
}
if (numberA == 2)
{
    Console.WriteLine ("Вторник");
}
if (numberA == 3)
{
    Console.WriteLine ("Среда");
}
if (numberA == 4)
{
    Console.WriteLine ("Четверг");
}
if (numberA == 5)
{
    Console.WriteLine ("Пятница");
}
if (numberA == 6)
{
    Console.WriteLine ("Суббота");
}
if (numberA == 7)
{
    Console.WriteLine ("Воскресенье");
}
