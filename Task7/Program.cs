Console.WriteLine ("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine ());
if (N>=100&N<1000)
{
    Console.WriteLine (N % 10);
}
else
{
   Console.WriteLine ("Введенное число не трехзначное"); 
}