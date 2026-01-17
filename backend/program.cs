
Console.WriteLine("Привет!");
Console.WriteLine("Кузьмина Диана Александровна");
Console.WriteLine(DateTime.Now);

bool fl=true;
while (fl){
    Console.Write("Введите имя:");
    string name= Console.ReadLine();
    Console.WriteLine($"Привет, {name}!");
    Console.WriteLine($"Сегодня -{DateTime.Now.DayOfWeek}");
    Console.Write("Хотите продолжить? (y/n): ");
    string otv=Console.ReadLine();
    if (otv != "y")
    {
        Console.WriteLine("Программа закончена");
        fl=false;
    }
}
