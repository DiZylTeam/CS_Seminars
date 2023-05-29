// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// -> " -2, -1, 0, 1, 2"

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("It is invalid value");
}
int result = number * -1;
while (result <= number)
{
    Console.Write(result + "; ");
    result++;
}