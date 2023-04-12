// Задача №44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//Метод построения чисел фибаначи
string FibNum(int num)
{
    string res = "0 1";
    long first = 0;
    long last = 1;
    for (int i = 2; i <= num; i++)
    {
        res += " " + (first + last);
        (first, last) = (last, last + first);
    }
    return res;
}

string res = "";
int n = ReadData("Введите n");
res = FibNum(n);
Console.WriteLine(res);
