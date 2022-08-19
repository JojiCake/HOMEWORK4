Console.WriteLine("Введите число: ");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString!);

var res= 0;

while(number > 10)
{
    res = res + (number % 10);
    number = number / 10; 
}
res = res + number;
Console.WriteLine(res);


