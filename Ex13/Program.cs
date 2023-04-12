Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber > 100)
{
    while (userNumber > 1000)
    {
        userNumber /= 10;
    }
    int thirdNumber = userNumber % 10;
     Console.Write($"В числе {userNumber} третья цифра: {thirdNumber}");
}
else Console.Write($"В числе {userNumber} нет третьей цифры");