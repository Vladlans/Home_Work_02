// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: " ?? "0");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: " ?? "0");
int numB = int.Parse(Console.ReadLine());
if(numA*numA == numB)
Console.WriteLine($"Число {numB} является квадратом числа {numA}");
else
if(numB*numB == numA)
Console.WriteLine($"Число {numA} является квадратом числа {numB}");
else
Console.WriteLine("Число не является квадратом другого");