//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
string? num = Console.ReadLine();
char [] array = num.ToCharArray();
if(array.Length>=3)
{
    Console.WriteLine("третья цифра это"+array[2]);
}
else
{
    Console.WriteLine("Такой цифры нет");
}