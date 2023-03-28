// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
int number= int.Parse(Console.ReadLine()??"o");
if (number%2==0)
{
    Console.WriteLine("четное число");
}
 else
{
    Console.WriteLine("Нечетное число");
}
