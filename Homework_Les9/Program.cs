//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void Shownums(int n)
{
    if (n > 1) Shownums(n - 1);
    Console.Write(n + " ");
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Shownums(num);



//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//5683

int SumofDig (int n)
{
    if (n > 0)  return SumofDig(n / 10) + n % 10;
    else return 0;
}

Console.Write(SumofDig(5683));


//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Shownums(int m, int n)
{
    if (n > m) Shownums(m, n - 1);
    
    Console.Write(n + " ");
    
}


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Shownums(num, n1);




//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int ReturnA (int a, int b)
{
    if (b > 1) return ReturnA (a, b - 1 ) * a;
    else return a;
}
Console.Write(ReturnA(2 ,2));


//_________________________HW_____________________________________

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int ShowSum (int m, int n)
{
    if (n > m ) return ShowSum (m, n - 1) + n;
        else return m;
}
Console.Write("Input 1 number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 1 number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(ShowSum(num1,num2));


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int AnkermanFun (int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }

    else if (n == 0 && m > 0)
    {
        return AnkermanFun (m - 1, 1);
    } 

    else  
    {
        return AnkermanFun ( m - 1, AnkermanFun (m, n -1 ));

    }
}


Console.Write("Input 1 number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 1 number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"{AnkermanFun(num1, num2)}");
*/