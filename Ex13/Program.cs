int userNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine("Вы ввели некорректные данные ");
    }
}
int number = userNumber("Введите целое число: ");
if (number > 100)
{
    while (number > 1000)
    {
        number /= 10;
    }
    int thirdNumber = number % 10;
    Console.Write($"В числе {number} третья цифра: {thirdNumber}");
}
else Console.Write($"В числе {number} нет третьей цифры");