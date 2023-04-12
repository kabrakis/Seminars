// Задача №42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//Метод преоброзования числа из 10-тичного в 2-ичный
string DecToBin(int num)
{
    string res = String.Empty;
    while (num > 0)
    {
        res += num % 2;
        num = num / 2;
    }

    return res;
}

string res = "";
int a = ReadData("Введите А");
res = DecToBin(a);
Console.WriteLine(res);

Console.WriteLine(Convert.ToString(a,2));
Console.WriteLine(Convert.ToString(a,8));
Console.WriteLine(Convert.ToString(a,16));