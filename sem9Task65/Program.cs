// // ---------------------------------------------------------------------
// //                                 Задача 65
// // Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
// // ---------------------------------------------------------------------

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// string ReadMN(int m, int n)
// {
//     if (m < n)
//     {
//         return m + " " + ReadMN(m + 1, n);
//     }
//     else
//     {
//         return String.Empty;
//     }
// }

void FromMToN(int m, int n)
{   
    if (m <= n)
    {
        Console.Write(m + " ");
        FromMToN(m + 1,n);
    }
    else
    {
        return;
    }
}
int m = ReadData("Введите число M");
int n = ReadData("Введите число N");
FromMToN(m, n);
