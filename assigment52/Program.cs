/*int[,] matrix = new int[,]
{
    {5, 8, 2, 1, 9},
    {3, 2, 1, 0, 7},
    {5, 4, 7, 9, 2},
};

for (int j = 0; j < matrix.GetLength(1); j++)
{
double sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
sum += matrix[i,j];
Console.WriteLine(sum /  matrix.GetLength(0));   
}*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Mатрица: ");
InputMatrix(matrix);

Console.Write("Средние арифметические столбцов равны: ");
Console.WriteLine();
for (int j = 0; j < matrix.GetLength(1); j++)
{
double sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
sum += matrix[i,j];
Console.Write ($"{sum /  matrix.GetLength(0)} \t");   
}

 