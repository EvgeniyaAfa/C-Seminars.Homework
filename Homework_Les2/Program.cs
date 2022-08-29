/*Задача 1.Семинар 2. Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

/*int FindBiggerDigit(int number) //написали метод, который показывает наибольшую цифру
{
    int ed = number % 10;
    int dec = number/10;
    int max;
    if (ed > dec) max = ed;
    else max = dec;
    return max;
}
int randnumber = new Random().Next(10,100); //создали переменную randnumber, в которую поместили случайные числа от 11 до 99
// нижний предел (10 ) учитывает , а верхний (100)  не учитывает, а отрезок до 99 вкл.
int biggerDigit = FindBiggerDigit(randnumber); //созадли отдельную переменную большего числа и отправили туда метод поиска этого числа 
Console.WriteLine($"Bigger digit of {randnumber} is {biggerDigit}");*/

/*Домашка. Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
//456 -> 456/10 - 45, 456 % 10 - 6
int FindTwoDiger(int number)
{
    int hund = number / 10;
    int ed = hund % 10;
    int numbertwo = ed;
    return numbertwo;
}
int randnumber = new Random().Next(100,1000);
int numbervtoroe = FindTwoDiger(randnumber);
Console.WriteLine($"Number two of {randnumber} is {numbervtoroe}");*/

// Домашка. Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
//356 -> 6 356 % 10
int TheThirdNumber (int number)
{
    int ed = number % 10;
    int numberthree = ed;
    if (number > 99 )
     Console.Write($"Third digit is {numberthree}");
      
    else 
      Console.Write($"Theres no third digit. Input anothere number");
      return numberthree;
      
}    
Console.Write("Input number  :  ");
int n = Convert.ToInt32(Console.ReadLine());
int numbertri = TheThirdNumber(n);

/*Домашка.Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
/*void Weekendornot (int number)
{
    if (number == 6) Console.Write("It's weekend");
    if (number == 7) Console.Write("It's weekend");
    
    if (number == 1) Console.Write("It isn't weekend");
    if (number == 2) Console.Write("It isn't weekend");
    if (number == 3) Console.Write("It isn't weekend");    
    if (number == 4) Console.Write("It isn't weekend");
    if (number == 5) Console.Write("It isn't weekend");
    if (number <= 0 || number > 7) Console.Write("Input correct information");
}

Console.Write("Input number  :  ");
int n = Convert.ToInt32(Console.ReadLine());
Weekendornot(n);
*/