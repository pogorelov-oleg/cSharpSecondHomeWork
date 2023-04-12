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
        else Console.WriteLine("Вы ввели некорректные данные. ");
    }
}
while (true)
{
    int weekDay = userNumber("Введите номер дня недели ");
    if (weekDay > 0 && weekDay < 6)
    {
        Console.Write("Рабочий день");
        break;
    }
    else if (weekDay > 5 && weekDay < 8)
    {
        Console.Write("Выходной день");
        break;
    }
    else Console.WriteLine("Нет такого дня недели");
}
