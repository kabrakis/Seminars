// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double k1 = ReadData("Введите число k1: ");
double b1 = ReadData("Введите число b1: ");
double k2 = ReadData("Введите число k2: ");
double b2 = ReadData("Введите число b2: ");
double k3 = ReadData("Введите число k3: ");
double b3 = ReadData("Введите число b3: ");
// поиск координат пересечения
(double x, double y) pointA = CrossPoint(k1, b1, k2, b2);
(double x, double y) pointb = CrossPoint(k2, b2, k3, b3);
(double x, double y) pointc = CrossPoint(k3, b3, k1, b1);

double x1 = pointA.x;
double y1 = pointA.y;
double x2 = pointb.x;
double y2 = pointb.x;
double x3 = pointc.x;
double y3 = pointc.x;
PrintData($"точка пересечения 3-х линий: x1={x1};y1={y1};x2={x2};y2={y2};x3={x3};y3={y3}");
double sideA = TriangleSide(x1, y1, x2, y2);
double sideB = TriangleSide(x2, y2, x3, y3);
double sideC = TriangleSide(x3, y3, x1, y1);
PrintData($"длина сторон треугольника: A= {sideA}; B= {sideB}, C={sideC}");
PrintData($"Площадь треугольника: S= {SquareTriangle(sideA,sideB,sideC)}");

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// метод вывода данных

void PrintData(string msg)
{
    Console.WriteLine(msg);
}

//комплексный метод
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
    double coorx1 = (b2-b1)/(k1-k2);
    double coory1=(k1*b2-k2*b1)/(k1-k2); 
    return (coorx1, coory1);
}

//стороны треугольника
double TriangleSide(double x1,double y1,double x2,double y2)
{
double result = Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2));
return result;
}

// площадь

double SquareTriangle (double a, double b, double c)
{
    double squareT = Math.Sqrt(((a+b+c)/2)*(((a+b+c)/2)-a)*(((a+b+c)/2)-b)*(((a+b+c)/2)-a)*(((a+b+c)/2)-c));
    return squareT;
}