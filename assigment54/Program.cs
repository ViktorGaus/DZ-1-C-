void InputArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = new Random().Next(1, 10);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}

void ResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int result = array[i, z + 1];
                    array[i, z + 1] = array[i, z];
                    array[i, z] = result;
                }
            }
        }
    }
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] array = new int[size[0], size[1]];
Console.WriteLine("Начальный массив: ");

InputArray(array);
PrintArray(array);
Console.WriteLine("Конечный массив ");
ResultArray(array);
PrintArray(array);