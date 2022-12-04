Console.Write("Введите пятизначное число : ");
int n = int.Parse(Console.ReadLine());

if (n / 10000 == n % 10 || (n / 1000) % 10 == n % 100)  
Console.Write("Является палиндромом");

else if (n < 9999 || n > 99999)
Console.WriteLine("Повторите попытку");

else
Console.Write("Не является палиндромом");