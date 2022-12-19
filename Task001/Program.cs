// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number / 100 == 0 || number / 1000 > 0)
Console.WriteLine("Число не входит в заданный диапазон!");
else 
{number = number % 100;
number = number / 10;
Console.WriteLine(number);
}