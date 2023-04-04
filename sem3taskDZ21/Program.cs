//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.


//функция запроса данных
double ReadData(string msg) 
{
    Console.WriteLine(msg);
    double res = double.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// Функция расчета растояния между точками в 3D
double CalcLen3D(double xA, double yA, double zA, double xB, double yB, double zB) 
{
    double res = 0;
    res = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
    return res;
}


double xA = ReadData("Введите координату xA: ");
double yA = ReadData("Введите координату yA: ");
double zA = ReadData("Введите координату zA: ");
double xB = ReadData("Введите координату xB: ");
double yB = ReadData("Введите координату yB: ");
double zB = ReadData("Введите координату zB: ");

Console.WriteLine(CalcLen3D(xA, yA, zA, xB, yB, zB));

