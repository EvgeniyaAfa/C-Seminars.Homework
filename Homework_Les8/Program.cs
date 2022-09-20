//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

// void ChangeRows(int[,] array, int row1, int row2) //делаем универсальный метод , который меняет местами любые 2 строки в масииве.
// {
//     if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0))
//         for (int j = 0; j < array.GetLength(1); j++)  //идем по кол-ву столбцов
//         {
//             int help = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = help;
//         }
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
// ChangeRows(myarray, 0, 1);
// Show2dArray(myarray);

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




