// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами

double[,] matrix = new double[3, 4];

void PrintMatrix(double[,] matr)              // Печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)                      // Заполнение матрицы рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10 ;             
        }
    }
}

FillArray(matrix);
PrintMatrix(matrix);
