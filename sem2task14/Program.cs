// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine(" Введите число");
int num = int.Parse(Console.ReadLine()??"o"); 
bool test1 = (num%7==0);
bool test2 = (num%23==0);
if(test1&&test2)
{
Console.WriteLine("число делиться на 23 и на 7");
}
else
{
Console.WriteLine("число не делиться на 23 и на 7");
}