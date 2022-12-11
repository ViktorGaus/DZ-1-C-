using System.Collections;

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
    array[i] =new Random().Next(10, 100);
    array[i] = array[i] / 10;
    }  
}


void ReleaseArray(double[] array)
{
    double max = 0, min = 1000;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    double sub = Math.Round((max - min), 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива {sub}");
}

Console.Write("Введите число элементов ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

InputArray(array);
Console.WriteLine($"[{string.Join(" , ", array)}]");
ReleaseArray(array);