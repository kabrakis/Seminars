﻿// Задача №26
// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе.

    int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
//метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg+res);
}
int CountDigit(int num)
{
    int res = 0;
    while(num>0)
    {
        res++;
        num=num/10;
        //res=(int)Math.Log(num)+1;
    }
    return res;
}
int num = ReadData("Введите число: ");
int res =CountDigit(num);
PrintResult("результат: ",res);