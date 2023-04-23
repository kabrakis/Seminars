// Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

// метод поиска суммы строки
int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}



int row = ReadData("Введите количество строк: ");
int col = ReadData("Введите количество столбцов: ");
int[,] arr2D = Gen2Darray(row, col, 10, 99);
Print2DArray(arr2D);

// поиск строки с наименьшей суммой эллементов
int minSumLine = 0;
int sumLine = SumLineElements(arr2D, 0);
for (int i = 1; i < arr2D.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(arr2D, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

