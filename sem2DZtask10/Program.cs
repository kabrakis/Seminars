﻿//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число"); //  Делаем запрос числа
int number= int.Parse(Console.ReadLine()??"o"); // Считываем число, проверяем на null
// и сохраняем его в выделенную ячейку
int firstNum = number/10; // Сперва избавимся от порядка сотен делением на 10,
// это можно сделать так как тип данных целочисленный, остаток не будет учитываться
int secondNum = firstNum%10; // теперь найдем остаток при деление на 10 используя "%"
Console.WriteLine(secondNum); // вывод остатка после деления на 10