int[,] matrix = new int[,]
{
    {5, 8, 2, 1, 9},
    {3, 2, 1, 0, 7},
    {5, 4, 7, 9, 2},
};

for (int i = 0; i < matrix.GetLength(0); i++)
//for (int j = 0; j < matrix.GetLength(1); j++)
{
    
    //int i = 0;
    int j = 0;
    Console.WriteLine("Введите номер строки ");
    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите номер столбца ");
    int b = int.Parse(Console.ReadLine());

    if (a > 3 || b > 5)
    {
    Console.WriteLine("Такой позиции нет, повторите попытку ");
    }
        else
        {
        i = a - 1;
        j = b - 1;
        Console.WriteLine($"Значение указанной позиции = {matrix[i,j]} ");
        break;
        }
}


