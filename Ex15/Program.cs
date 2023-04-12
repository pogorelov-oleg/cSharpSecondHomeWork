Console.Write("Введите номер дня недели: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
if (userNumber == 1)
{
    Console.Write("Понедельник");
}
else if (userNumber == 2)
{
    Console.Write("Вторник");
}
else if (userNumber == 3)
{
    Console.Write("Среда");
}
else if (userNumber == 4)
{
    Console.Write("Четверг");
}
else if (userNumber == 5)
{
    Console.Write("Пятница");
}
else if (userNumber == 6)
{
    Console.Write("Суббота");
}
else if (userNumber == 7)
{
    Console.Write("Воскресенье");
}
else Console.Write("Нет такого дня недели");
