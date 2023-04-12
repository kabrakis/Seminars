// Задача №40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

//  метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}


// метод 
bool TrianTest(int a, int b, int c)
{
 bool res = false;
 if (a<=(b+c) && b<=(a+c) && c<=(a+b))
 {
    Console.WriteLine("+");
    return true;
 }
 else
 {
     Console.WriteLine("-");
 }

 return res;
}
bool res;
int a=  ReadData ("Введите А");
int b=  ReadData ("Введите B");
int c=  ReadData ("Введите C");
TrianTest (a,b,c);

