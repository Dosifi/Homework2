// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number > 100000) 
Console.WriteLine("Число не входит в заданный диапазон!");
if (number < 100)
Console.WriteLine("Третьей цифры нет!");
if(number >= 100 && number < 1000)
{number = number % 10;}
if(number >= 1000 && number < 10000)
{number = number % 100;
number = number / 10;}
if(number >= 10000 && number < 100000)
{number = number % 1000;
number = number / 100;}
Console.WriteLine(number);