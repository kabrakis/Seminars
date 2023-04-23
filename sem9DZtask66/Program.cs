int GetSumBetweenNandM(int m, int n)
{
    if (n > m)
        return n + GetSumBetweenNandM(m, n - 1);
    return m;
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = GetSumBetweenNandM(m, n);
Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}"); 

