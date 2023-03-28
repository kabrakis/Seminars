// // Задача №12
// // Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит остаток от деления.
Console.WriteLine("Введи первое число");
int numOne = int.Parse(Console.ReadLine()??"o"); //  null safty
 Console.WriteLine("Введи второе число ");
int numTwo = Convert.ToInt32(Console.ReadLine()); // не дает ввести пустое число, менее быстрый способ
bool res = (numOne%numTwo==0);

if(res)
{
Console.WriteLine("первое число кратно первому");
}
else
{
   Console.WriteLine("первое число не кратно второму"); 
}