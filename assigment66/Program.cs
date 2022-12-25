using System;
using static System.Console;
Clear();
Write("Введите первое число : ");
int m=int.Parse(ReadLine());
Write("Введите второе число: ");
int n=int.Parse(ReadLine());

WriteLine($"{Sum(m, n)}");

int Sum(int m, int n)
{
if (n == m) return n;
return m + Sum(m + 1, n);
}