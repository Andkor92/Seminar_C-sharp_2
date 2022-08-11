// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 & number < 8)
{
    if (number > 5)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Дней недели 7. Введите число от 1 до 7 включительно.");
}
