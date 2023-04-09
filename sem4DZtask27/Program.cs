//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// метод чтени данных
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

//  метод подсчитывания суммы всех цифр в числе
int SumAllNum(int num)
{
    int res = 0;
    while(num>0)
    {
        res+=num%10;
        num=num/10;
        
    }
    return res;
}
int num = ReadData("Введите число: ");
int res =SumAllNum(num);
PrintResult("Сумма всех цифр в числе: ",res);