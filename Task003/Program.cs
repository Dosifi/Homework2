// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число: ");
int daynumber = int.Parse(Console.ReadLine()!);

if(daynumber < 1 || daynumber > 7) 
Console.WriteLine("Это не день недели");
else
{if(daynumber == 6 || daynumber == 7)
Console.WriteLine("Выходной!");
else 
Console.WriteLine("Этот день не выходной");}