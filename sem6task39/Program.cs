// Задача №39
// Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// метод считывания данных
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res = int.Parse(Console.ReadLine() ?? ("0"));

//     return res;
// }
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
// метод переворота  массива
void SwapArr(int[] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        buf = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = buf;
    }
}

int[] SwapNewArr(int[] arr)
{
    int [] outArr = new int [arr.Length];
    for (int i = 0; i < arr.Length/2; i ++)
    {
        outArr[outArr.Length-1-i]=arr[i];
    }
    return outArr;
}

// int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(12, 10, 100);
Print1DArray(arr);
SwapArr(arr);
int [] newArray = SwapNewArr (arr);
Print1DArray(arr);
Print1DArray(newArray);