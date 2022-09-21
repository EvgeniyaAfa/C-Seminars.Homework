//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
/*
int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; // объявил и инициализировал значением по умолчанию(0)
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}

void ShowArray (int [] array)

{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");


Console.WriteLine();

}    


int FindPositiveSum (int [] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0) sum = sum + array[i];
  }
   
  
  return sum;
}

int FindNegativeSum (int [] array)

{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
       if(array[i] < 0) sum = sum + array[i];
  

  return sum;
}

Console.Write("Input size of array:   "); // Запрашиваем базовые величины
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value:   ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value:   ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max); // генерируем массив, выделяем память, генерируем его с помощью метода
// а в качестве аргументов отправляем в него те характеристики, которые выше запросили у пользователя.
//myArray теперь хранит ифнормацию, его надо вывести и потом после вывода можно искать мин и макс значение.

ShowArray(myArray);

int negativesum = FindNegativeSum(myArray); // создаем переменную, которую будет искать метод, созданный выше
// в массиве myArray
int positivesum = FindPositiveSum(myArray);

Console.WriteLine ($"Sum of positive elements is {positivesum} \nSum of negative elements is {negativesum}");
*/

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.

/*int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; 
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}

void ShowArray (int [] Array)

{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");


Console.WriteLine();

}    

int [] Swap(int [] array)
{   
   
   for (int i = 0; i < array.Length; i++)
   {
     array[i] *= (-1); 
   }

return array;
}

Console.Write("Input size of array:   "); 
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, -20, 30);
ShowArray(myArray);
ShowArray(Swap(myArray));
*/

//Задача 3. Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.

int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; 
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}

void ShowArray (int [] Array)

{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");


Console.WriteLine();

}    

bool RanNumber(int [] array, int rannumber)
    
{  
   for (int i = 0; i < array.Length; i++)
   {  if (rannumber == array[i])
      return true;
      
   }
     return false;
}

Console.Write("Input your number:  ");
int rannumber = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreateRandomArray(10, -10, 10);
ShowArray(myArray);
Console.WriteLine($"{RanNumber(myArray, rannumber)}");


//Задайте одномерный массив из 12 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

/*int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; 
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}

void ShowArray (int [] Array)

{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");


Console.WriteLine();

}    

int DobleDigit(int [] Array)
{  int count = 0;

  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i] >= 0  && Array[i] < 100)  
    count ++;
  }
   return count;
}
int [] myArray = CreateRandomArray(10, 0, 1000);
ShowArray(myArray);
Console.WriteLine($" count of double diggits is {DobleDigit(myArray)}");
*/

//------------------------ Домашка------------------------------------------

//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; 
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}

void ShowArray (int [] Array)

{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");


Console.WriteLine();

}    

int  EvenNum (int [] array)
{
  int count = 0;

  for (int i = 0; i < array.Length; i++)
  {  
     if (array[i] % 2 == 0) count = count + 1;
  } 
    return count;

}



int[] myArray = CreateRandomArray(10, 100 , 1000);
ShowArray(myArray);
Console.WriteLine($" count of even numbers is {EvenNum(myArray)}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*int [] CreateRandomArray (int size,int minValue, int maxValue)
{
    int [] newarray = new int[size]; 
    
    for (int i=0; i < size; i ++)
       newarray[i] = new Random().Next(minValue,maxValue + 1);

    return newarray;
}
void ShowArray (int [] Array)

{
    for (int i = 0; i < Array.Length; i++)
    Console.Write(Array[i] + " ");


Console.WriteLine();

}    

int OddNum (int [] array)
{ 
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 == 1) sum += array[i];

  }
  return sum;
}
int[] newArray = CreateRandomArray(5, 0, 10);
ShowArray(newArray);
Console.WriteLine($" Sum of odd elements is {OddNum(newArray)}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.

// int [] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int [] newarray = new int[size]; 
    
//     for (int i=0; i < size; i ++)
//        newarray[i] = new Random().Next(minValue,maxValue + 1);

//     return newarray;
// }

// double [] CreateRandomDoubleArray (int size,double minValue, double maxValue)
// {
//     double [] newarray = new double[size]; 
    
//     for (int i=0; i < size; i ++)
//        newarray[i] = new Random().NextDouble() ;

//     return newarray;
// }

// void ShowArrayD (double [] Array)

// {
//     for (int i = 0; i < Array.Length; i++)
//     Console.Write(Array[i] + " ");


// Console.WriteLine();

// }   
// void ShowArray (int [] Array)

// {
//     for (int i = 0; i < Array.Length; i++)
//     Console.Write(Array[i] + " ");


// Console.WriteLine();

// }   


// int Find  (int [] array)

// { 
//   int result = 0;
//   int posmin = 0;
//   int posmax = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     {
//       if (array[i] < array[posmin]) posmin = i;
//     }

//     if (array[i] > array[posmax]) posmax = i;
  
//   }
//    result = array [posmax] - array [posmin];
//    return result;
// }

// int [] myarray = CreateRandomArray(10, -20, 50);
// double [] mydoublearray = CreateRandomDoubleArray (10, 0, 1);
// ShowArray(myarray);
// ShowArrayD(mydoublearray);
// Console.WriteLine($" deference is {Find}");



