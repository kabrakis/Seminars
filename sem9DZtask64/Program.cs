// Задайте значение N. Напишите программу, к
// оторая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}



void LineGeneratorRec(int numN)
{
    int i = numN;
    Console.Write(i + " ");
    if (numN <= 1)
    {

    }
    else
    {
        LineGeneratorRec(numN - 1);
    }
}

int numN = ReadData("Введите число: ");
LineGeneratorRec(numN);
