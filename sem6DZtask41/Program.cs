// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// метод для проверки числа, больше-ли оно нуля
int CountPosNum(int num)
{
    int count = 0;

    while (num > 0)
    {
        int val = ReadData("Введите число: ");

        if (val > 0)
        {
            count++;
        }
        num--;

    }
    return count;
}



int num = ReadData("Сколько чисел будем сравнивать? ");

// проверим num на ноль или отрицательное значние
if (num <= 0)
{
    Console.WriteLine("Колличество сравниваемых числе не должно быть меньше или равно нулю!");
}
else
{
    int res = CountPosNum(num);
    Console.WriteLine("Чисел больше нуля: " + res);
}
