Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber > 0 && userNumber < 6)
{
    Console.Write("Рабочие дни");
}
else if (userNumber > 5 && userNumber < 8)
{
    Console.Write("Выходной день");
}
else Console.Write("Нет такого дня недели");
