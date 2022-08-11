// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int threeDigit = number;

if (number > 99)
{
    while (threeDigit > 999)
    {
        int count = 0;
        threeDigit = threeDigit / 10;
        count++;
    }
    int result = threeDigit % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет!");
}
