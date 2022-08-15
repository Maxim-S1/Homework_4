// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
A = Math.Abs(A);
int res = 0;
int i = 0;
for (i = 0; i <= A+1; i++)
{
    int B = A % 10;
    A = A / 10;
    res = res + B;
}

Console.WriteLine($"Сумма цифр в заданном числе = {res}");
