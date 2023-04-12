// Задача №45
// Напишите программу, 
// которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

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
// метод копирования массива
int [] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       outArr[i]=arr[i];
    }
    return outArr;
}


int[] arr = Gen1Darray(12, 10, 100);
Print1DArray(arr);
int [] newArray = CopyArr (arr);
Print1DArray(arr);

// int [] outArr = new int[args.Length];
// arr.CopyTo(outArr,0);
// Print1DArray(outArr);
