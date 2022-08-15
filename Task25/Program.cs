// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

Console.WriteLine("Введите число А: ");
double A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень В: ");
double B = Convert.ToInt32(Console.ReadLine());

double res = 1;
if (B < 0)
{
    for (double i = B; i <= -1; i++)
    {
        res = res * 1 / A;
    }
    Console.WriteLine($"Число {A} возведенное в натуральную степень {B} = {res}");
}
else
{
    for (int i = 1; i <= B; i++)
    {
        res = res * A;
    }
    Console.WriteLine($"Число {A} возведенное в натуральную степень {B} = {res}");
}
