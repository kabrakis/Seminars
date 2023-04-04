﻿// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.
using System.Numerics;
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
void PrintResult(string msg, BigInteger res)
{
    Console.WriteLine(msg + res);
}
BigInteger Factor(int num)

{
    BigInteger res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}
int num = ReadData("Введите число n: ");
BigInteger res = Factor(num);
PrintResult("n!= ", res);