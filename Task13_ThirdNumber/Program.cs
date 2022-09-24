// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

    while (number / 1000 > 0)
        number = number / 10;
    if (number / 100 <= 0)
        Console.WriteLine("Третьей цифры нет");
    else
        Console.WriteLine($"Третья цифра - {number % 10}");