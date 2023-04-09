// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//метод считывания данных
int ReadData(string msg)

{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
// метод печати массива
void Print1DArray(int[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}
//метод генерации массива 
int[] Gen1DArray(int len,int top, int but)
{
    // проверяем границы, чтобы нижнняя граница не была больше верхней
       if (but > top)
    {
        int buf = but;
        but = top;
        top = buf;
    }
int [] res= new int [len];
for (int i=0;i<len;i++)
{
    res[i]=new Random().Next(but,top);
}
return res;
}

int lenArr = ReadData("Введите длинну массива");
int numA = ReadData ("Введите от каких случайных чисел будет заполнен массив");
int numB = ReadData ("Введите до каких случайных чисел будет заполнен массив");
int [] arr = Gen1DArray(lenArr,numB,numA);
Print1DArray(arr);
