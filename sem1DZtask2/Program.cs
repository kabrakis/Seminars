// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine()??"o");
Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine()??"o");
int max = 0;
int min = 0;
 if(numberOne>numberTwo)
 {
    Console.WriteLine("максимальное число это "+numberOne, "минимальное это "+numberTwo);
 }
 else
 {
    Console.WriteLine("минимальное число это "+numberOne, "максимальное число это "+numberTwo);
 }