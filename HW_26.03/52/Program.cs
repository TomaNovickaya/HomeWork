// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите m");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
FillArrayRandomNumbers(matrix);


for (int j = 0; j < matrix.GetLength(1); j++)
{
    double avg = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        avg= (avg + matrix[i, j]);
    }
    avg = avg / n;
    Console.Write($"Среднее арифметическое: {avg}   ");
}
Console.WriteLine();
PrintArray(matrix);



void FillArrayRandomNumbers(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
        }
    }
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j]+ "    ");
        }
                Console.WriteLine("");
    }
}