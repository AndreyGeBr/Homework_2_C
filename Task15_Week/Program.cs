// программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите цифру: ");
int day = int.Parse(Console.ReadLine());

if (day > 0 && day < 8)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine ("Этот день выходной");
    }
    else
    {
        Console.WriteLine ("Этот день будний");
    }
}
else
{
    Console.WriteLine ("В неделе всего 7 дней");
}

