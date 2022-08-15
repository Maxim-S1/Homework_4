// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.

Console.Write("Ввведите 1 элемент: ");
string N1 = Console.ReadLine();

Console.Write("Ввведите 2 элемент: ");
string N2 = Console.ReadLine();

Console.Write("Ввведите 3 элемент: ");
string N3 = Console.ReadLine();

Console.Write("Ввведите 4 элемент: ");
string N4 = Console.ReadLine();

Console.Write("Ввведите 5 элемент: ");
string N5 = Console.ReadLine();

Console.Write("Ввведите 6 элемент: ");
string N6 = Console.ReadLine();

Console.Write("Ввведите 7 элемент: ");
string N7 = Console.ReadLine();

Console.Write("Ввведите 8 элемент: ");
string N8 = Console.ReadLine();

string [] array = {N1, N2, N3, N4, N5, N6, N7, N8};

// int length = array.Length;
// for (int i = 0; i < length; i++)
// {
//     Console.Write(array[i] + " ");
// }

Console.WriteLine(string.Join(", ", array));