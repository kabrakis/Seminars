Console.WriteLine("Введите трехзначное число");
string? numLine = Console.ReadLine();
if (numLine != null)
{
//    char[] charArray = numLine.ToCharArray();
//    Console.WriteLine(charArray[charArray.Length-1]);
int num = int.Parse(numLine);
int res = num % 10;
Console.WriteLine(res);
}

