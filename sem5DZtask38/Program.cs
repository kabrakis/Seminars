// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//метод генерации массива
double[] Gen1DarrayReal(int len, int minValue, int maxValue)

{


    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    }
    return arr;
}

// метод печати массива
void Print1DArray(Double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод поиска разницы между максимальным значением массива и минимальным
double DiffMaxMin(double[] arr)
{

    double res = 0;
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
        }
        else
        {
            if (max < arr[i])
            {
                max = arr[i];
            }
        }
    }
    res = max - min;
    return res;
}


double res;
int Length = ReadData("Введите длину массива: ");
double[] testArray = Gen1DarrayReal(Length, 10, 100);
res = DiffMaxMin(testArray);
Print1DArray(testArray);
Console.WriteLine("Разница между максимальным и минимальным значением " + res);
