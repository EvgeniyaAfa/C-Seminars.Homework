//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {   
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
        
//             newArray[i,j] = new Random().Next(minval, maxval + 1);     
           
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);

//Задайте двумерный массив размера m на n, 
//каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

// int[,] CreateRan2dArray(int rows, int columns)
// {   
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
        
//             newArray[i,j] = i + j;   
           
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myarray = CreateRan2dArray(m, n);
// Show2dArray(myarray);

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {   
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
        
//             newArray[i,j] = new Random().Next(minval, maxval + 1);     
           
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
        
//     }

//     Console.WriteLine();
// }

// int[,] FindEvenElement(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i,j] * array[i,j];
    
    

// return array;
// }


// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);
// Console.WriteLine();

// int[,] Quad = FindEvenElement(myarray);
// Show2dArray(Quad);


//Задайте двумерный массив. Найдите сумму элементов, 
//находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {   
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {   
//         for (int j = 0; j < columns; j++)
//         {
//             newArray[i,j] = new Random().Next(minval, maxval + 1);    
//         }
    
             
//     }  
//     Console.WriteLine();     
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
        
//     }

//     Console.WriteLine();
// }

// int FindSum (int[,] array)
// {   int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             if (i == j) sum = array[i, j] + 1;
//     }    
//     return sum;    
    
// }

// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);
// Console.WriteLine();
// int sum = FindSum(myarray);

// Console.Write($"Sum of elements is {sum}");

//______________________Домашка____________________________

//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double [,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {   
//     double[,] newArray = new double[rows, columns];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             int intPart = new Random().Next(minval, maxval);
//             double doublePart = new Random().NextDouble();
//             newArray[i , j] = intPart + Math.Round(doublePart, 1);
//         }
//     } 
           
//       return newArray;  
// }

// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }
// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double [,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {  
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
        
//             newArray[i,j] = new Random().Next(minval, maxval + 1);     
           
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// bool  Findindex (int[,] arr, int ranindex)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {    if (ranindex == arr[i,j])
//                   return true;  
//         }  
//     }
//     return false;
// }

// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);
// Console.Write("Input your number:  ");
// int rannumber = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{Findindex(myarray, rannumber)}");

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {  
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
        
//             newArray[i,j] = new Random().Next(minval, maxval + 1);     
           
//       return newArray;  
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
        
//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }

// int FindAverage (int[,] array)
// {   int sum = 0;
//     int avr = 0;
    

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {   
//             sum += array[j, i];
            
//         }   
//      avr = sum / array.GetLength(0);
//     Console.WriteLine();          
//     }
//     return avr;

// }
// Console.Write("Input rows number: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());


// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);
// Console.WriteLine($"{FindAverage(myarray)}");


