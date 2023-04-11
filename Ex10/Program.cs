Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
int a1 = userNumber / 100;
int a2 = userNumber % 10;
int result = (userNumber - a1 * 100 - a2) / 10;
Console.WriteLine($"{userNumber} -> {result}");
