// //записывает количество столбцов и строк
// int ReadInt(string text){
//     System.Console.Write(text);
//     int RowCol = Convert.ToInt32(Console.ReadLine());
//     return RowCol;
// }

// // //Генирирует матрицу со случайными вещественными числами
// double[,] GenerateMatrix(int rows, int cols){
//     Random rand = new Random();
//     double[,] matrix = new double[rows,cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = Math.Round(rand.NextDouble()*20 -10, 2);
//         }
//     }
//     return matrix;
// }



// // Выводит матрицу в консоль
// void PrintArr(double[,] matrix){
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("введите количество столбцов: ");
// System.Console.WriteLine();
// double[,] myMatrix = GenerateMatrix(rows,cols);
// PrintArr(myMatrix);


// Задача 50: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Random rnd = new Random();
// int rows = rnd.Next(2, 15);
// int cols = rnd.Next(2, 15);

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[,] GenerateMatrix(int rows, int cols)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[rows, cols];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(0, 20);
//         }
//     }
//     return matrix;
// }

// void printMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t"); //красивая табуляция \t
//         }
//         System.Console.WriteLine();
//     }
// }

// int RowPosition = ReadInt("введите номер строки в матрице: ");
// int ColsPosition = ReadInt("введите номер столбца в матрице: ");
// System.Console.WriteLine();
// var myMatrix = GenerateMatrix(rows, cols);
// printMatrix(myMatrix);

// if (RowPosition < 0 || RowPosition > myMatrix.GetLength(0) - 1) Console.WriteLine("Нет такого элемента");
// else if (ColsPosition < 0 || ColsPosition > myMatrix.GetLength(1) - 1) Console.WriteLine("Нет такого элемента");
// else System.Console.WriteLine($"значение элемента матрицы: {myMatrix[RowPosition-1, ColsPosition-1]}");

// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t"); //красивая табуляция \t
        }
        System.Console.WriteLine();
    }
}

void RowArithmeticalMean(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {Math.Round(sum / matrix.GetLength(0), 2)}");
    }
}

int rows = ReadInt("введите количество строк в матрице: ");
int cols = ReadInt("введите количество столбцов матрицы: ");
System.Console.WriteLine();
var myMatrix = GenerateMatrix(rows, cols);
printMatrix(myMatrix);
System.Console.WriteLine();
RowArithmeticalMean(myMatrix);