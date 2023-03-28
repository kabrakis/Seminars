// Считываем данные с консоли
string? inline = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if(inline!=null)
{

     //Парсим введеное число
    int inNuber = int.Parse(inline);
    int outStrPow = (int)Math.Pow(inNuber,2);

    //int outNumberTest = inline.ToCharArray()[0]*inline.ToCharArray()[0];
    // находим квадрат числа
    int outNumber = inNuber*inNuber;

    //Выводим данные в консоль
    Console.WriteLine(outStrPow);
}
