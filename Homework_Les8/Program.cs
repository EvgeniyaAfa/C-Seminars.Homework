//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)

            newArray[i, j] = new Random().Next(minval, maxval + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2) //делаем универсальный метод , который меняет местами любые 2 строки в масииве.
{
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0))
        for (int j = 0; j < array.GetLength(1); j++)  //идем по кол-ву столбцов
        {
            int help = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = help;
        }
}

Console.Write("Input rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateRan2dArray(m, n, min, max);
Show2dArray(myarray);
ChangeRows(myarray, 0, 1);
Show2dArray(myarray);
/*

//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, 
//если это невозможно, программа должна вывести сообщение для пользователя.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)

//             newArray[i, j] = new Random().Next(minval, maxval + 1);

//     return newArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }

//     Console.WriteLine();
// }
// void ChangeRowswithColumns(int[,] array)
// {
//     if (array.GetLength(0) == array.GetLength(1))
//         {   for (int i = 0; i < array.GetLength(0) - 1; i++) 
//                 for (int j = i + 1; j < array.GetLength(1); j++) 
//                 {
//                     int help = array[i,j];
//                     array[i,j ] = array[j,i];
//                     array[j,i] = help;
//                 }
//         }
//     else Console.Write("Недопустмый формат. Введите другие значения");
//         Console.WriteLine();

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
// ChangeRowswithColumns(myarray);
// Show2dArray(myarray);

//--------------------------------------Домака---------------------------------------------
//Задача 54: Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
{   
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        
            newArray[i,j] = new Random().Next(minval, maxval + 1);     
           
      return newArray;  
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }

    Console.WriteLine();
}

void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k]) 
                {
                    int help = array [i,j];
                    array[i,j ] = array[i,k];
                    array[i,k] = help;
                }
            }

        }
}

Console.Write("Input rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateRan2dArray(m, n, min, max);
Show2dArray(myarray);
Console.WriteLine();
SortToLower(myarray);
Show2dArray(myarray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)

            newArray[i, j] = new Random().Next(minval, maxval + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine(" ");
    }

    Console.WriteLine();
}

void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
   

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
    
    {    if (i == 1)
            minRow += array[i - 1,j];
            sum += array[i, j];
    }         
        if (sum < minRow)
         {
            minRow = sum;
            minSumRow = i;
         }   
    }
    Console.Write($"{minSumRow + 1} строка");
}


Console.Write("Input rows number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myarray = CreateRan2dArray(m, n, min, max);
Show2dArray(myarray);
Console.WriteLine();
NumberRowMinSumElements(myarray);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRan2dArray(int rows, int columns, int minval, int maxval)
// {
//     int[,] newArray = new int[rows, columns];

//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)

//             newArray[i, j] = new Random().Next(minval, maxval + 1);

//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine(" ");
//     }

//     Console.WriteLine();
// }


// bool DoubleArrayLenght (int[,] arrayone, int [,] arraytwo)
// {
//     bool lenght;
//         if (arrayone.GetLength(0) == arraytwo.GetLength(1)) lenght = true;
//             else lenght = false;
//     return lenght;        
// }

// int [,] DoubleArray (int [,] arrayone, int [,] arraytwo)
// {
//     int[,] doublearray = new int[arrayone.GetLength(0), arraytwo.GetLength(1)];
//     for (int i = 0; i < arrayone.GetLength(0); i++)
//         for (int j = 0; j < arraytwo.GetLength(1); j++)
//             for (int k = 0; k < arrayone.GetLength(0); k++)
//                 doublearray[i,j] += arrayone[i,k] * arraytwo [k,j];
//     return doublearray;    
     
// }

// Console.Write("Input rows number of first matrix: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number of first matrix: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input rows number of second matrix: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input columns number of second matrix: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max number: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// Console.Write("First matrix is:  ");
// int[,] myarray = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarray);
// Console.WriteLine();
// Console.WriteLine("Second matrix is:  ");
// int[,] myarr = CreateRan2dArray(m, n, min, max);
// Show2dArray(myarr);
// Console.WriteLine();

// DoubleArrayLenght(myarray, myarr);
// Console.WriteLine($"Matrix multiplication is {DoubleArrayLenght(myarray, myarr)}  ");

// int[,] newarr = DoubleArray(myarray,myarr);
// Show2dArray(newarr);



/*
//60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] CreateRandom3dArray(int rows, int columns, int sheet)
{
    int[,,] array = new int[rows, columns, sheet];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            int k = 0;
            while (k < sheet)
            {
                int number = new Random().Next(10, 100);
                if (FindNum(array, number)) continue;
                array[i, j, k] = number;
                k++;
            }
        }
    return array;

}

bool FindNum(int[,,] array, int number)
{
    bool find = false;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) find = true;

            }
    return find;


}

void ShowIndex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{ array[i, j, k]} ({ i},{ j},{ k})");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Input rows number: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns number: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input quantity of sheet: ");
int sheet = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] myarray = CreateRandom3dArray(rows, columns, sheet);
ShowIndex(myarray);
*/



