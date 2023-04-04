// Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
    
   //чтение данных консоли 
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
long SumSimple(int numA)
{
long sum =0;
for (int i =1; i<=numA;i++)
{
    sum+=i;
    //sum=sum+i
}
return sum;
}

long SumGauss(int numA)
{
    return ((1+(long)numA)*(long)numA)/2;
}

int numberA=ReadData("Введите число А: ");
//DataTime d1 = DataTime.Now;
long res1 =SumSimple(numberA);
//DataTime d2 = DataTime.Now;
long res2 = SumGauss(numberA);
PrintResult("Сумма чисел от 1 до А(простой метод)", (int)res1);
PrintResult("Сумма чисел от 1 до А(простой метод)", (int)res2);