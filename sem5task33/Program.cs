// Задача №33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

void SearchElmInArr (int element, int[] arr)
{
for(int i =0; i<arr.Length; i++)
{
   bool elmFind = false;
    if (arr[i]==element)
    {
        Console.WriteLine("Эелемент найден "+i);
    elmFind = true;
    }
if (elmFind==false)
{
    Console.WriteLine("Элемент не найден");
}
}
}

int Length = ReadData("Введите длину массива: ");
int[] arr = Gen1Darray(Length,999,-999);
Print1DArray (arr);
int N = ReadData("Введите N: ");
SearchElmInArr (N, arr);
