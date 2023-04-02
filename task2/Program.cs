// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Не использовать строки для расчета (решать только при помощи операций % и /).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int ThirdDigit(int number)
    {
        while (number > 999)
            {
                number = number / 10;
            }
        return number % 10;
        }
    
bool ValidNum(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("There is no third digit");
        return false;
    }
    return true;
}

int number = ReadInt("Input a number");
int newNumber = ThirdDigit(number);

if (ValidNum(number))
{
    System.Console.WriteLine($"Third digit of {number} is {newNumber}.");
}
