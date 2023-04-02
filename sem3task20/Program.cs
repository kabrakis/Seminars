// Задача №20
// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние между ними в 2D пространстве.
   
    int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res =  int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

double CalcLen2D(int x1, int y1, int x2, int y2)
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((x1-x2),2)*Math.Pow((y1-y2),2));
    return res;
}

int x1 =ReadData("Введите координату X1: ");
int x2 =ReadData("Введите координату X2: ");
int y1 =ReadData("Введите координату y1: ");
int y2 =ReadData("Введите координату y2: ");

Console.WriteLine("Растояние между точками А и В: "+ CalcLen2D(x1,y1,x2,y2));