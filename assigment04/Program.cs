Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());
int a0 = 2;
if(a > 1)
{
    while(a0 <= a)
    {
    Console.Write($" {a0} " );
    a0 = a0 + 2;
    }
}