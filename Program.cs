
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными дробными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());
// double[,] arr = new double[3, 4];
// Random rand = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         arr[i, j] = Math.Round((rand.NextDouble() * 20) - 10, 1);
//     }
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write($"{arr[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает число, и возвращает 
// индексы числа в двумерном массиве или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] arr = new int[4, 4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-10, 11);
//     }
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите число: ");
// int a = int.Parse(Console.ReadLine());

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         if (arr[i, j] == a)
//         {
//             Console.WriteLine($"индексы числа в массиве {i},{j}");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("числа нет");
//         }
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] arr = new int[3, 4];
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(0, 11);
//     }
// }
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// double sum = 0;
// for (int j = 0; j < arr.GetLength(1); j++)
// {

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         sum = sum + arr[i, j];

//     }
//     double avg = sum / arr.GetLength(0);
//     Console.WriteLine($"авг в столбце {j} равно {avg}");
// }

