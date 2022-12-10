Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int step = 1;

for (int i = 0; i < b; i++)
{
step = step * a;
} 


Console.WriteLine(step);