while (true)
{
    Console.Write("Введите трехзначное число: ");
    string userInput = Console.ReadLine() ?? "";
    int userNumber = int.Parse(userInput);
    if (userNumber >= 100 && userNumber < 1000)
    {
        int a1 = userNumber / 100;
        int a2 = userNumber % 10;
        //  int result = (userNumber - a1 * 100 - a2) / 10;                      первая версия вычислений...слишком душная и сложная, версия из "Этолонного решения" проще.
        int result = userNumber / 10 % 10;
        Console.WriteLine($"Число: {userNumber}. Вторая цифра: {result}.");
        break;
    }
    else Console.WriteLine("Вы ввели неверное число.");
}