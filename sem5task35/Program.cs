// Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//     int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int res =  int.Parse(Console.ReadLine() ?? ("0"));

//     return res;
// }

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

void Print1DArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int ElmIntRange(int[] arr, int min, int max)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] < max && arr[i] > min)
        {
            res++;
        }
            return res;
}


// int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(123, 1000, 0);
Print1DArray(arr);
// int min = ReadData("min: ");
// int max = ReadData("max ");
int res = ElmIntRange(arr,10,99);
Console.WriteLine("результат "+ res);
