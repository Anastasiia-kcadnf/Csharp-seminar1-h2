// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool IsWeekend(int dayWeek)
{
    if(dayWeek == 6 || dayWeek == 7)
    {
        return true;
    }
    return false;
}

bool ValidDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("This is no weekday, repeat input");
    return false;
}

int dayWeek = ReadInt("Input number of the day of the week");

if (ValidDay(dayWeek))
{
    if (IsWeekend(dayWeek))
    {
        System.Console.WriteLine($"Day {dayWeek} is weekend.");
    }
    else
    {
        System.Console.WriteLine($"Day {dayWeek} is not weekend.");
    }
}
