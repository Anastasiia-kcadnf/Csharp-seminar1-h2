// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Не использовать строки для расчета (решать только при помощи операций % и /).
// 456 -> 5
// 782 -> 8
// 918 -> 1

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = ReadInt("Input a 3-digit number");

if (number < 100 || number > 999)
{
    System.Console.WriteLine("Number is not 3-digit, repeat input");
    return;
}

int SecondDigit(int number)
{
    int sot = number / 10;
    int dec = sot % 10;

    int result = dec;
    return result;
}

System.Console.WriteLine($"Second digit of number {number} is {SecondDigit(number)}");

