//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//метод ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// рекурсивный метод подсчета суммы чисел от m до n
int RecSumBetweenNandM(int m, int n)
{
    if (n > m)
        return n + RecSumBetweenNandM(m, n - 1);
    return m;
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");
int result = RecSumBetweenNandM(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");

