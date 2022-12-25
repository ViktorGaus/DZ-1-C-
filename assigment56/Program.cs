using System.Data.Common;

int[,] matrix = new int[,]
{
    {3, 1, 5,},
    {2, 9, 8,},
    {1, 0, 2,},
    {7, 2, 9,},
};
int row = 0;
int minsum = 100;
for (int i = 0; i < matrix.GetLength(0); i++)
{
int sum = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
sum += matrix[i,j];
if(sum < minsum)
    {
    minsum = sum;
    row = i+1;
    }

}
Console.WriteLine("Строка с минимальной суммой номер ");
Console.WriteLine(row);
