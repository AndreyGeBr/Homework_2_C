//  Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = (number % 100) / 10;
Console.WriteLine(result);