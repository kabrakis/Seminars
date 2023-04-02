int day = int.Parse(Console.ReadLine() ?? "o"); 
if(day<=0 || day >7) // меньше или равно нули ИЛИ больше 7
{
    Console.WriteLine("Это не день недели");
}
else
{
    if(day>=1 && day <= 5)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}