// ---------------------------------------------------------------------
//                                 Задача 67
// примает на вход число и возвращает сумму числа
// ---------------------------------------------------------------------



// int SumDigitRec(int num)
// {
//     if (num > 0)
//     {
//         return num % 10 + SumDigitRec(num / 10);
//     }
//     else
//     {
//         return 0;
//     }

// }

//Рекур.метод
//Ввод данных
int ReadData(string msg)
{
    Console.Write(msg);
    int res = int.Parse(Console.ReadLine() ?? "0");
    return res;
}

//Рекур.метод
int SumDigRec(int m)
{
    if(m>0)
    {
        return m%10+SumDigRec(m/10);
    }
    else
    {
        return m;
    }
}

int M = ReadData("Введите число: ");
int Sum = SumDigRec(M);
Console.Write(Sum);