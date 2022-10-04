// Задача 5
Console.Clear();
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
if (num1 * num1 == num2)
{
    Console.WriteLine ($"{num1} корень {num2}");
}
else if (num2 * num2 == num1)
{
    Console.WriteLine($"{num2} корень {num1}");
}
else
{
    Console.WriteLine($"{num1} не является корнем {num2} и наоборот");
}