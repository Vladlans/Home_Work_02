//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите y: ");
double y = Convert.ToDouble(Console.ReadLine());
if (x > 0 && y > 0)
Console.WriteLine("1 Четверть");
else if (x > 0 && y < 0)
Console.WriteLine("4 четверть");
else if (x < 0 && y > 0)
Console.WriteLine("2 четверть");
else if (x < 0 && y < 0)
Console.WriteLine("3 четверть");
else if (x == 0 || y == 0)
Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y");