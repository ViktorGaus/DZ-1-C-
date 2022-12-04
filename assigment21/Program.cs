Console.Write("Введите кооординату x 1-ой точки: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кооординату y 1-ой точки: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кооординату z 1-ой точки: ");
double z = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите кооординату x 2-ой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кооординату y 2-ой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите кооординату z 2-ой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(
            Math.Sqrt(
            Math.Pow(x1 - x, 2) + 
                Math.Pow(y1 - y, 2) +
                 Math.Pow(z1 - z, 2)), 2
    ));