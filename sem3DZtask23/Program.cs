//  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.   
    
    int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

string lineGenerator (int num, int pow)
{
    string res = String.Empty;
    for(int i =1; i<=num; i++)
    {
        res+=Math.Pow(i,pow)+" ";
    }
    return res;
}
int numN = ReadData("Введите N");

Console.WriteLine(lineGenerator(numN,1));
Console.WriteLine(lineGenerator(numN,3));