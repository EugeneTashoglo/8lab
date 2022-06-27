try
{
    Console.WriteLine("Введите первое дробное:");
    double first = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе дробное:");
    double second = double.Parse(Console.ReadLine());
    Console.WriteLine("Ответ " + Math.Pow(first, second));
    while (true) ;
}
catch (Exception e)
{
    Console.WriteLine($"Ошибка: {e.Message}");
}