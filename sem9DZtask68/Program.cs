// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и 

// Функция аккермана через рекурсию
 uint Akk(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akk(n - 1, 1);
    else
        return Akk(n - 1, Akk(n, m - 1));
}
// метод считывания данных
uint ReadData(string msg)
{
    Console.WriteLine(msg);
    uint res = uint.Parse(Console.ReadLine() ?? ("0"));

    return res;
}
uint m = ReadData("Введите M");
uint n = ReadData("Введите N");
uint res = Akk(m,n);
Console.Write ("результат: "+res);