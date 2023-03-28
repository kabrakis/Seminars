// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numberOne = int.Parse(Console.ReadLine()??"o");
Console.WriteLine("Введите второе число");
int numberTwo = int.Parse(Console.ReadLine()??"o");
  if(numberOne>numberTwo)
 {
    Console.WriteLine("максимальное число это "+numberOne);
 }
 else
 {
    Console.WriteLine("максимальное число это "+numberTwo);
 }