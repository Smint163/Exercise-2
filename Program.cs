Console.WriteLine("Введите число 1");
string number0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string number1 = Console.ReadLine();
int num0 = Convert.ToInt32(number0);
int num1 = Convert.ToInt32(number1);

if (num0 > num1)
{
    Console.WriteLine($"max = {num0}, min = {num1}");
}
else 
Console.WriteLine($"max = {num1}, min = {num0}");