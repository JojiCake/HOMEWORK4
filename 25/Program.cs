Console.WriteLine("Введите число A");
string? numberString1 = Console.ReadLine();
int number = int.Parse(numberString1!);

Console.WriteLine("Введите число B");
string? numberString2 = Console.ReadLine();
int number2 = int.Parse(numberString2!);

double flex = Math.Pow(number,number2);

Console.WriteLine(flex);