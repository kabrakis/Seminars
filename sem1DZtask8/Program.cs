// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число до которого будет выводиться значения");
int number= int.Parse(Console.ReadLine()??"o");
int count = 0;
int outNumber = 1;
while (outNumber <= number)
{
    Console.WriteLine(outNumber);
    outNumber++;
}