string? numLine = Console.ReadLine();
if (numLine != null)
{
    int numN = int.Parse(numLine);
    int startNum = numN * (-1);
    string res = String.Empty;
    while (startNum <= numN)
    {
        startNum++;
        res = res + startNum + " ";
    }
    Console.WriteLine(res);
}