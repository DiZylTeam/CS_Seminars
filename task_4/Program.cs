// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter three-digit number: ");
int number = int.Parse(Console.ReadLine());
if (number > 999 || number < 100)
{
    Console.WriteLine("It is invalid value");
}
int result = number % 10;
Console.WriteLine(result);