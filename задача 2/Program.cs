// задача 9
Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;
Console.WriteLine($"первое и после цифры числа {num} -> {a1} {a2}");