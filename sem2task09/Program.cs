System.Random numSintezator = new System.Random();
// Вариант1
int randNum = numSintezator.Next(10,100);
Console.WriteLine(randNum);
// short firstNum = (short)(randNum/10);
// short secondNum = (short)(randNum%10);


int firstNum = randNum/10;
int secondNum = randNum%10;

if(firstNum>secondNum)
{
    Console.WriteLine("Первое число больше " + firstNum + " Второго "+secondNum);

}
else
{
    Console.WriteLine(secondNum);
}
//Вариант 2
char[] digits =numSintezator.Next(10,100).ToString().ToCharArray();
// 23 -> "23" -> ['2','3']
Console.WriteLine(digits);
firstNum = (int)(digits[0])-48;// -48 это -преоброзование из таблицы ascll;
firstNum = (int)(digits[1])-48;
// <переменнаяЮ = (условие)?<значение1>:<значение 2>;
// if (условие)
// {
// <> = <>
// }
// else
// {
//   <>=<>  
// }
int res = (firstNum>secondNum)?firstNum:secondNum;
Console.WriteLine(res);

//Вариант 3
int randNumberArr = numSintezator.Next(10,100);
Console.WriteLine(randNumberArr);
int[] indxAnsw = new int[90];