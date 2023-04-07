// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int[,] matrix= new int[3,4];

void PrintArrey(int[,] matr)
{

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        Console.Write($"   {matrix[rows,columns]}")   ;
    }
    Console.WriteLine();
}
}
void FillArrey(int[,] matr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(0,10);
            if (number != matr[i,j])
            {
                Console.WriteLine("Такого числа в массиве нет");
                     
            }
            else Console.WriteLine($" Значение {number}");
        }
            }
}
FillArrey(matrix);
Console.WriteLine();
PrintArrey(matrix);