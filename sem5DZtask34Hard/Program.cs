// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



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

// метод проверки четности значений в массиве
int EvenCount(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}

//метод пузырька
int[] Buble(int[] arr, int length)
{
    int[] res;
    int buf = 0;
    for (int count = 0; count < length; count++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                buf = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = buf;
            }
        }
    }
    res = arr;
    return res;
}

//метод подсчета
int[] CountSort(int[] arr, int min, int max)
{
    int[] countArr = new int[max - min + 1];
    int index = 0;

    for (int i = 0; i < countArr.Length; i++)
    {
        countArr[i] = 0;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        countArr[arr[i] - min]++;
    }

    for (int i = min; i <= max; i++)
    {
        while (countArr[i - min]-- > 0)
        {
            arr[index] = i;
            index++;
        }
    }
    return arr;
}

int length = ReadData("Введите длину массива: ");
int min = ReadData("Введите минимальное значение массива: ");
int max = ReadData("Введите максимальное значение массива: ");
int[] arr = Gen1Darray(length, min, max);
Print1DArray(arr);
int[] arr2 = Gen1Darray(length, min, max);
Print1DArray(arr2);
int res = EvenCount(arr);
Console.WriteLine("Колличество четных чисел в массиве: " + res);


//вывод на экран метод пузырька
DateTime d1 = new DateTime();
Console.WriteLine("Сортировка пузырьком: ");
int[] sortBuble = Buble(arr, length);
Print1DArray(sortBuble);
Console.WriteLine("Время по окончанию: " + d1);
Console.WriteLine(DateTime.Now - d1);


//вывод на экран метод подсчета
DateTime d2 = new DateTime();
Console.WriteLine("Сортировка подсчетом: ");
int[] sortCount = CountSort(arr2, min, max);
Print1DArray(sortCount);
Console.WriteLine("Время по окончанию: ");
Console.WriteLine(DateTime.Now - d2);