/*Console.WriteLine("Введите элементы массива: ");
int[] mass = Console.ReadLine().Split(" ").Select(a => int.Parse(a)).ToArray();

int count = 0;
for (int i = 0; i < mass.Length; i++)
        if (mass[i] > 0)
    {
    count = count + 1;
    }
Console.WriteLine($"Количество положительных элементов = {count}");
*/
Console.WriteLine("Введите элементы массива: ");
int[] mass = Console.ReadLine().Split(" ").Select(a => int.Parse(a)).ToArray();

int count = 0;
foreach (int element in mass)
if (element > 0) count++;
Console.WriteLine($"Количество положительных элементов = {count}");
