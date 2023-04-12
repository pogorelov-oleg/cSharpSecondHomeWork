while (true)
{
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
    int number = userNumber("Введите трехзначное число: ");
    if (number >= 100 && number < 1000)
    {
        int a1 = number / 100;
        int a2 = number % 10;
        //  int result = (userNumber - a1 * 100 - a2) / 10;                      первая версия вычислений...слишком душная и сложная, версия из "Эталонного решения" проще.
        int result = number / 10 % 10;
        Console.WriteLine($"Число: {number}. Вторая цифра: {result}.");
        break;
    }
    else Console.WriteLine("Вы ввели неверное число.");
}