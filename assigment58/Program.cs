
int[,] firstMartrix = new int[,]
{
    {5, 8, 9},
    {1, 0, 7},
    {5, 4, 2},
};
int[,] secomdMartrix = new int[,]
{
    {5, 8, 2,},
    {3, 2, 1,},
    {5, 4, 7,},
};
int[,] resultMatrix = new int[3,3];
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(($"{array[i,j]}\t") + " ");
    }
    Console.WriteLine();
  }
}
void SuperMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int mult = 0;
            mult = firstMartrix[i,j] * secomdMartrix[i,j];
            resultMatrix[i,j] = mult;
        }
    }
}
SuperMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteArray(resultMatrix);