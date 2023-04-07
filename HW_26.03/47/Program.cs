// 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.

Console.WriteLine("Введите m");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, columns];
FillArrayRandomNumbers(matrix);
PrintArray(matrix);

void FillArrayRandomNumbers(double[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "    ");
        }
        
        Console.WriteLine(" ");
    }
}