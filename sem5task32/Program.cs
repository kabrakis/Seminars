// Задача №32
// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

    int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

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

void  InversArr (int [] arr)
{
for (int i =0; i < arr.Length; i++)
{
    arr[i]=arr[i]*(-1);
}
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length,999,-999);
Print1DArray (arr);
InversArr(arr);
Print1DArray(arr);