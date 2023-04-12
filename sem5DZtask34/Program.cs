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
int  EvenCount (int[] arr)
{
    int res= 0;
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]%2==0)
        {
            res++;
        }
    }
    return res;
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length, 10, 100);
Print1DArray(arr);
int  res = EvenCount(arr);
Console.WriteLine("Колличество четных чисел в массиве: "+res);