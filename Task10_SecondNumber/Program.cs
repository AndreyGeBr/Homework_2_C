//  Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите целое трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int result = (number / 10) % 10;

if ((number > 99) && (number < 1000))
  {
    Console.WriteLine ($"Вторая цифра: {result}");
  }
  else
  {
    Console.WriteLine ("Вы ввели не трехзначное число");
  }
