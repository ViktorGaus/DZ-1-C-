void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

Console.Write("Введите число элементов");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

int result = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
result += 1;
} 
Console.WriteLine($"[{string.Join(" , ", array)}]");
Console.WriteLine(result);