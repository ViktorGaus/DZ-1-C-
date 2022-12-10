Console.WriteLine("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());

int[] massiv = new int[a];

for (int i = 0; i < massiv.Length; i++)
    {

    Console.WriteLine($"Введите {i + 1} элемент массива");
    massiv[i] = int.Parse(Console.ReadLine());

    }

Console.WriteLine($"|| {string.Join(" , " , massiv)} ||");
