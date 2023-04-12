// Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
//метод генерации массива
int[] Gen1Darray(int len, int minValue, int maxValue)

{

    if (minValue > maxValue)
    {
        int buf = minValue;
        minValue = maxValue;
        maxValue = buf;
    }
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue + 1);
    }
    return arr;
}
// метод печати массива
void Print1DArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}
// метод подсчета суммы нечетных значений в массиве
int  SumElmNegPos (int[] arr)
{
    int sum= 0;
    for (int i=0; i<arr.Length; i=i+2)
    {
        sum+=arr[i];
    }
    return sum;
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length, 10, 100);
Print1DArray(arr);
int  res = SumElmNegPos(arr);
Console.WriteLine("Сумма эллементов на нечетных позициях: "+res);