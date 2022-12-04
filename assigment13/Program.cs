Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

else

{
    while(number > 999)
    {
        number /= 10;
    }
    Console.WriteLine(number % 10); 
}
