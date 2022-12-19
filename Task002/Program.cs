// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if(number > 100000) 
Console.WriteLine("Число не входит в заданный диапазон!");
else
{
string numberText = Convert.ToString(number);
if (numberText.Length > 2){
  Console.WriteLine($"третья цифра {numberText[2]}");
}
else {
  Console.WriteLine("третьей цифры нет");
}}