//Lesson 6. 
// Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

// int [] CreateRandomArray (int size,int minValue, int maxValue)
// {
//     int [] newarray = new int[size]; 
    
//     for (int i=0; i < size; i ++)
//        newarray[i] = new Random().Next(minValue,maxValue + 1);

//     return newarray;
// }

// void ShowArray (int [] Array)

// {
//     for (int i = 0; i < Array.Length; i++)
//     Console.Write(Array[i] + " ");


// Console.WriteLine();

// }   

// int[] ReverseArray (int[] Array)
// {
//     for (int i = 0; i < Array.Length / 2; i++)
//     {
//       int hepl = Array[i]; // записываем 0 элемент
//       Array[i] = Array[Array.Length - 1 - i]; // в первый элемент записываем последний
//       Array[Array.Length - 1 - i] = hepl;
//     }
//     return Array;
// }

// Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input min possible value: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input max possible value: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = ReverseArray(myArray);
// ShowArray(myArray);

//Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
//a < b + c

// bool Find (int a, int b, int c)
// {   
//     bool result = false;
//     if (a < b + c && b < a + c && c < a + b)
//       {
//          result = true;
//       }
        
//      return result;   
// }
// Console.Write("Проверим получится ли треугольник!");
// Console.Write("Введите значение первой стороны: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение второй стороны: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение третьей стороны: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{Find(num1, num2, num3)}");


//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.



//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// string Binary (int num)
// {
//     string elem = string.Empty;
//     while (num > 0)
//     {
//         int n = num % 2;
//         elem = Convert.ToString(n) + elem;
//         num = num /2;
//     }
//     return elem;
// }
// Console.Write("Input number:  ");
// int n = Convert.ToInt32(Console.ReadLine());
// string result = Binary(n);
// Console.WriteLine(result);

//____________________ Домашка __________________________
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 12, 10, 8, -2, 0 - 3


// Console.Write("Введите количество чисел: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arrayNumbers = new int[number];

// void FillNumbers(int m)
// {
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i+1} число: ");
//     arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Find (int[] arrayNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < arrayNumbers.Length; i++)
//   {
//     if(arrayNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// FillNumbers(number);

// Console.WriteLine($"Введено чисел больше 0: {Find(arrayNumbers)} ");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
 
 
// double x = (b2 - b1) / (k2 - k1);
// double y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");




