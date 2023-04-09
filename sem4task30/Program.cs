//  Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.  

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
void Print1DArray(int[] arr)

{
    
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]+",");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int[] Gen1DArray(int len,int top, int but)
{
   
int [] res= new int [len];
for (int i=0;i<len;i++)
{
    res[i]=new Random().Next(but,top);
}
return res;
}

int lenArr = ReadData("Введите длинну массива");
int [] arr = Gen1DArray(lenArr,1,0);
Print1DArray(arr);

