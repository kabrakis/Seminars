//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите количество сравниваемых чисел");
            int index, lengthArray = int.Parse(Console.ReadLine()??"o");
            int[] array = new int[lengthArray];
            Console.WriteLine("Введите эти числа через пробел:");
            string[] str = Console.ReadLine().Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            for (index = 0; index < (lengthArray < str.Length ? lengthArray : str.Length); ++index)
                array[index] = Convert.ToInt32(str[index]);
            Console.WriteLine("Введенные числа (после прочтения нажмите enter)");
            for (index = 0; index < lengthArray; ++index)
                Console.Write("{0} ", array[index]);
            Console.ReadLine();
int max = array[0];
int count = lengthArray;
index = 0;
while (count>index)
if(max>array[index])
{
    index++;
}
else
{
    max = array[index];
    index++;
}
Console.WriteLine("Максимальное число из введеных "+max);
