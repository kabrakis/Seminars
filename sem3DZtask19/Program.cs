//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Функция проверки числа на его полиндромность 
bool Paltest(int num)
{
    //сверяем первые две цифры и последние две цифры 
    bool res = false;
    int d1 = num / 10000;
    int d5 = num % 10;
    int d2 = (num / 1000) % 10;
    int d4 = (num / 10) % 10;
    if (d1 == d5 && d2 == d4)
        res = true;
    return res;
}

// функция ввода данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

int num = ReadData("Введите число: ");
Console.WriteLine( Paltest(num));