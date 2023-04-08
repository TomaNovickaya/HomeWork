// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArrey(int[,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        Console.Write($"   {matr[i,j]}")   ;
    }
    Console.WriteLine();
}
}

void FillArrey(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10);
        }
    }
}

void SelectionSort(int[,] matr)
{
    int temp=0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int c = 0; c < matr.GetLength(1)-1; c++)
            {
               if(matr[i,c]<matr[i,c+1])
               {
                temp=matr[i,c+1];
                matr[i,c+1]=matr[i,c];
                matr[i,c]=temp;
               } 
            }
        }
        }
    }
 

int[,] matrix= new int[3,3];

FillArrey(matrix);
PrintArrey(matrix);
Console.WriteLine();
SelectionSort(matrix);
Console.WriteLine();
PrintArrey(matrix);
