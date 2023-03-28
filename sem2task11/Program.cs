// Задача №11
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100,1000);
Console.WriteLine(num);
int firstNum = num/100;
int lastNum = num%10;
int newNum = firstNum * 10 + lastNum; // первое число умножаем на 10 просто потому что мы работаем в дясятках а не в сотнях 
Console.WriteLine(newNum);

