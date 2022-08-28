/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input number 1 :  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 2 :  ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 3 :  ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine($"Max is  {max} ");*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number  :  ");
int number = Convert.ToInt32(Console.ReadLine());

{
    if (number % 2 == 0)
    {
    Console.WriteLine("Number " + number + " is even");
    }   

    else
    {
    Console.WriteLine("Number is odd");
    } 
}
*/
/*Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number  :  ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current < number)
{
   if (current %2 ==0)
   {
     Console.Write(current + "  " );  
   }
   
   current += 1;
}
*/