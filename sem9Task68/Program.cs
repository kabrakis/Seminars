//==========================================
//#69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
//==========================================

//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
long PowRec(int a, int b)
{
    if (b > 0)
    {
        return a * PowRec(a, b - 1);
    }
    else
    {
        return 1;
    }

}
long MyRecPow (int a, int b)
{
    if (b==2)
    {
        return 4;
    }
    else
    {
        return a * MyRecPow(a, b /2)*MyRecPow(a, b /2);
    }
}

int A = ReadData("Введите число: ");
int B = ReadData("Введите степень числа: ");
//long powAB = PowRec(A,B);
long myPowAB = MyRecPow (A,B);
//Console.Write(powAB);
Console.Write(myPowAB);