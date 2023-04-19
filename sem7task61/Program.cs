//треугольник Паскаля

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

long Factor(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}

void PrintPascalTriangle(int nRaw)
{
    for (int i = 0; i < nRaw; i++)
    {
        for(int k =0; k<nRaw-i;k++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factor(i) / (Factor(j) * Factor(i - j)));
        }
        Console.WriteLine();
    }
}

int countRaw = ReadData("Введите колличество строк треугольника Паскаля");
PrintPascalTriangle(countRaw);