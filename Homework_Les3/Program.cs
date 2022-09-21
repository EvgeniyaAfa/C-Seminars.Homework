
/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


int FindQuadrant (double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write ("Input x coordinate :  ");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y coordinate :  ");
double ya = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xa, ya);
Console.WriteLine($"num of quad is {quadrant}");/*


/*Задача 2. Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
void FindRange (int num)
{
    if (num == 1) Console.Write($"Range of quad {num} x + , y +");
    if (num == 2) Console.Write($"Range of quad {num} x - , y +");
    if (num == 3) Console.Write($"Range of quad {num} x - , y -");
    if (num == 4) Console.Write($"Range of quad {num} x + , y -");
    if (num <= 0 || num >4) Console.Write($"This quad isn't exist");
}
Console.Write("Input number of quad:  ");
int quad = Convert.ToInt32(Console.ReadLine());
FindRange(quad);
*/


/*Напишите программу, которая принимает на вход число (n) 
и выдаёт квадраты чисел от 1 до n.*/
//5
/*void ReturnKvadrat (int n)
{
   int current = 1;
   int kvadrat = 0;
   
   while (current < n)
   {  
      kvadrat = current * current;
      Console.Write(kvadrat + " ");

      current ++;
   } 
}
Console.Write("Input number:  ");
int number = Convert.ToInt32(Console.ReadLine());
ReturnKvadrat(number);
/*


/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.*/
/*double FindDistance (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt ((x2-x1)* (x2-x1) + (y2-y1) *(y2 - y1));
}
Console.Write("Enter 1st :  ");

double xA = Convert.ToDouble(Console.ReadLine());
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter 2st : ");

double yA = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance (xA, xB,yA, yB);
Console.Write($"Distaanse is {dist}");
*/

//Домашка. Задача 19.  Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом
//56765 -1 chislo = 56765 / 10000 -> 5
//56765 -2 chislo = 56765 / 100 = 56 % 10 -> 6
//56765 -4 chislo = 56765 /10 = 5676 % 10 -> 6
//56765 -5 chislo = 56765 % 10 -> 5
// 5 chislo == 1 chislo
// 4 chislo == 2 chislo
/*void PalindromorNot (int number)
{
   int chislo1 = number / 10000;
   int chislo2 = number / 100;
   int edchislo2 = chislo2 % 10;
   int chislo4 = number / 10;
   int edchislo4 = chislo4 % 10;
   int chislo5 = number % 10;

     if (chislo5 == chislo1 && edchislo4 == edchislo2)
     {
           Console.Write("Number is palindrom");
     }
           else 
     {
           Console.Write("Number isn't palindrom");  
     }      

}
Console.WriteLine("Input number:  ");
int num = Convert.ToInt32(Console.ReadLine());
PalindromorNot(num);


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

/*double FindDistance (double x1, double y1, double x2, double y2, double z1, double z2)
{
    return Math.Sqrt ((x2-x1)* (x2-x1) + (y2-y1) *(y2 - y1) + (z2 - z1) * (z2 - z1));
}
Console.Write("Enter 1st :  ");

double xA = Convert.ToDouble(Console.ReadLine());
double xB = Convert.ToDouble(Console.ReadLine());
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter 2st : ");

double yA = Convert.ToDouble(Console.ReadLine());
double yB = Convert.ToDouble(Console.ReadLine());
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance (xA, xB,yA, yB, zA, zB);
Console.Write($"Distaanse is {dist}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*void ReturnKub (int n)
{
   int current = 1;
   int kub = 0;
   
   while (current < n)
   {  
      kub = current * current * current ;
      Console.Write(kub + "|");

      current ++;
   } 
}
Console.Write("Input number:  ");
int number = Convert.ToInt32(Console.ReadLine());
ReturnKub(number);*/
