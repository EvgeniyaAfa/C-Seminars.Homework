// Задача 1. Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А
/*int FindSum (int number)
{
    int sum = 0;
    for(int current = 1; current <= number; current++ )
     sum += current;
    
    return sum;
}
Console.Write("Input positive inger number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
*/

// Задача 2. Напишите программу, которая принимает на вход число и 
//выдаёт количество цифр в числе.

/*int FindQuantity (int number)
{
    int size = 0;
    while (number > 0) 
    {
        number = number/10; 
        size++;
    }
    
    return size;
}
Console.Write("Input number: ");
int dig = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Quantity' diggits of {dig} is {FindQuantity(dig)}");
*/


// Задача 3. Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N
// 5 = 1*2*3*4*5
/*int Fact (int number)
{
   int Factorial = 1;
   
   for(int current = 1; current <= number; current ++)
   Factorial *= current; 
   
   return Factorial;
}
Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial of {n} is {Fact(n)}");
*/

// Задача 4. Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

/*void FillArray(int[] numbers )
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(0,   2);
        index += 1;
    }
}  
void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int count = 0;
    while (count < lenght)
    {
        Console.Write(collection[count] + " " );
        count +=1;
    }
}     
int [] array = new int [8];

FillArray(array);
PrintArray(array);
*/

// Метод создания любого случайного массива.
/*int [] CreateRandomArray(int size, int minValue, int maxValue) // создаем случайный массив, в каечства аргументов в него идет размер и с какаого и до какого будет происходить выборка
{ // тут происходит процесс генерации
  int[ ] newArray = new int [size]; // выделяем память создаем ньюэррэй и кладем туда переменную инт в кол-ве сайз штук
   for( int i = 0; i < size; i++) //цикл - переменная индекс, чтобы перебирать элементы, условия существавания цикла, и если мы хоти идти по каждому элемнты то делаем и ++, если по каждому второму и+2
 newArray[i] = new Random().Next(minValue, maxValue + 1);  //обращаемся к элементу массива по его индексу текущему и туда записываем метод некст для рандомной генерации массива +1 потому что в метод нью рандом 1 число входит, а последнее нет.
   return newArray;
}

// Метод который вывод любой массив
void ShowArray (int [] array) //в качествве аргументов отправляем массив
{ 
    for (int i = 0; i < array.Length; i ++) //если перемення размер массива не была введена то через эррэй ленц можно обратится к размеру
      Console.Write(array[i] + " "); // тут будем выводитт элемент массива.
    Console.WriteLine();

}  

ShowArray(CreateRandomArray(8, 0, 1));
*/


//Домашка.Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

/*int Stepen (int numA, int numB)
//5,3 = 5*5*5 = 
{
    int current = 1;
    int result = 1;
    while (current <= numB)
    {
      result *= numA;  
      current++;
    }

 return result; 

}
Console.Write("Введите число, которое нужно возвести в степень:   ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа:  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {a} возведено в  {b}-ю степень и получилось {Stepen(a,b)}");
*/

//Домашшка. Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 23 - 2+3 = 5
// 345 = 3+4+5 = 12
//25 % 
/*int FindSumofnum (int number)
{   
    
    int result = 0;
    while (number > 0) //23>0
    {   
        result += number % 10; //23 % 10 = 3
        number = number / 10; 
        
    }
 return result;

}
Console.WriteLine ("Input number:  ");
int sumofdiggit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of diggits  is {FindSumofnum(sumofdiggit)}");
*/



//Домашшка. Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*int [] CreateRandomArray(int size, int minValue, int maxValue) 
{ 
  int[ ] newArray = new int [size]; 
  size = 8;
   for( int i = 0; i < size; i++) 
  
 newArray[i] = Convert.ToInt32(Console.ReadLine());
  
   return newArray;
}

void ShowArray (int [] array) 
{ 
    for (int i = 0; i < array.Length; i ++) 
      
      
      Console.Write(array[i] + " "); 
      
    Console.WriteLine();

}  
Console.WriteLine("Введите элемены массива:  ");
ShowArray(CreateRandomArray(8, 0, 1));
/*            
 

