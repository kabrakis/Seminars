// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
int number= int.Parse(Console.ReadLine()??"o");
int outNumber = 1;
while (outNumber <= number)
{
    if(outNumber%2==0)
    Console.WriteLine(outNumber);
    outNumber++;
}
