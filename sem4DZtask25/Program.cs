// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//чтение данных консоли 
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
//метод вывода результата
void PrintResult(string msg, int res)
{
    Console.WriteLine(msg + res);
}

// метод возведения в степень через цикл
int Pow(int numA, int numB)
{
    int pow = 1;

    // pow=  Math.Pow(numA, numB);
    for (int i = 0; i < numB; i++)
    {
        pow *= numA;
    }

    return pow;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");
int res1 = 0;
// проверяем число на 0
if (numberB <= 0)
{
    Console.WriteLine("Показательно должен быть больше 0");
}

else
{
    res1 = Pow(numberA, numberB);
    Console.WriteLine("результат возведения в степень " + res1);
}
