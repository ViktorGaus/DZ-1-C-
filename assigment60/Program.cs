
void InputMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
       matrix[i, j, k] = new Random().Next(10, 100);
      }
    }
  }     
}
        
void PrintMatrix(int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = 0; k < matrix.GetLength(2); k++)
      Console.Write($"{matrix[i, j, k]} \t");
    }
    Console.WriteLine();
  }
}

void ResultMatrix (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"x({i}) y({j}) ");
      for (int k = 0; k < matrix.GetLength(2); k++)
      {
      Console.Write( $"z({k})={matrix[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
Console.WriteLine("Mатрица: ");
InputMatrix(matrix);
PrintMatrix(matrix);
ResultMatrix(matrix);
