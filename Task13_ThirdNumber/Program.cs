// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
number = Math.Abs(number);

if (number > 99) 
{
    while (number > 999)
    {
        number = number / 10;
    } 
    Console.WriteLine ($"Третья цифра = {number % 10}");   
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}