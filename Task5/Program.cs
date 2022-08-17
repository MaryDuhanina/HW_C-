Console.WriteLine ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine ());
int counter = -N;//берем левый диапазон
while (counter <=N)
{
    Console.WriteLine (counter + "");
    counter++;
}
