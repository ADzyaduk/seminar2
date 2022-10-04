// See https://aka.ms/new-console-template for more information
Console.Clear();

int num = new Random().Next(100, 1000);
int num1 = new Random().Next(100, 1000);
int res = num % num1;
if (res == 0)
{
    Console.WriteLine($"Число {num} кратное {num1}");
}
else 
{
    Console.WriteLine($"Число {num} не кратное {num1} остаток - {res}");
}