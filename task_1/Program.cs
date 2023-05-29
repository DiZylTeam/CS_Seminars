// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Enter a number_1: ");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter a number_2: ");
int number_2 = int.Parse(Console.ReadLine());
if (number_1 == number_2 * number_2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}