Console.Write("Введите координату Х1 : ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату Х2 : ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату У1 : ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите координату У2 : ");
double k2 = double.Parse(Console.ReadLine());

double NULL = (b2 - b1) / (k2 - k1);
double intersection_point = k1 * NULL + b1;

if (k1 == k2 && b1 == b2)
Console.WriteLine("Прямые совпадают ");

else if (k1 == k2 && b1 != b2)
Console.WriteLine("Прямые параллельны ");

else
Console.WriteLine($"Точка пересечения прямых ({intersection_point} ; {intersection_point})");




