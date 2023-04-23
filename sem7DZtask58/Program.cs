// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:




// метод считывания данных
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int res = int.Parse(Console.ReadLine() ?? ("0"));

    return res;
}

// метод генерации  двумерного массива
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

//метод печати массива
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

// метод умножения матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    int sum = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
Console.WriteLine("");
Console.WriteLine("Введите размеры двух матриц :");
Console.WriteLine("");
int rowFirst = ReadData("Введите количество строк первой матрицы: ");
Console.WriteLine("");
int colFirst = ReadData("Введите количество столбцов первой матрицы: ");
Console.WriteLine("");
int rowSecond = ReadData("Введите количество строк второй матрицы: ");
Console.WriteLine("");
int colSecond = ReadData("Введите количество столбцов второй матрицы: ");
Console.WriteLine("");
int[,] arr2DFirst = Gen2Darray(rowFirst, colFirst, 10, 99);
Console.WriteLine("Первая матрица:");
Print2DArray(arr2DFirst);
Console.WriteLine("");
int[,] arr2DSecond = Gen2Darray(rowSecond, colSecond, 10, 99);
Console.WriteLine("Вторая матрица:");
Print2DArray(arr2DSecond);

int[,] resultMatrix = new int[rowFirst, colFirst];
MultiplyMatrix(arr2DFirst, arr2DSecond, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print2DArray(resultMatrix);

