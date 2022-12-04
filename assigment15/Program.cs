Console.Write("Введите цифру дня недели: ");
int daynum = int.Parse(Console.ReadLine());

if(daynum == 6 || daynum == 7)
Console.WriteLine("Выходной день");

else if(daynum < 1 || daynum > 7)
Console.WriteLine("Повторите попытку");

else
Console.WriteLine("Рабочий день");
