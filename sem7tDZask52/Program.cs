// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

//метод генерации массива
int[,] Gen2Darray(int countRow, int countColum, int minValue, int maxValue)

{
    int[,] arr = new int[countRow, countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            arr[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return arr;
}

//метод печати двумерного массива
void Print2DArray(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// метод печати одномерного массива
void Print1DArray(double[] arr)

{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод поиска среднего значения столбца в двумерном массиве
double[] ColMean(int[,] arr, int column)

{
    double[] mean = new double[column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            mean[j] += arr[i, j];
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        mean[i] = mean[i] / arr.GetLength(0);
    }
    return mean;

}



int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
double[] res = new double[col];
int[,] arr2D = Gen2Darray(row, col, 10, 99);
Print2DArray(arr2D);
// чтобы выделить нужное место двумерному массиву проверяем чего больше, строк или столбцов
if (col > row)
{
    res = ColMean(arr2D, col);
}
else
{
    res = ColMean(arr2D, row);
}
Print1DArray(res);
