// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArrey1(int[,] matr1)
{

for (int i = 0; i < matr1.GetLength(0); i++)
{
    for (int j = 0; j < matr1.GetLength(1); j++)
    {
        Console.Write($"   {matr1[i,j]}")   ;
    }
    Console.WriteLine();
}
}

void FillArrey1(int[,] matr1)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i,j]= new Random().Next(1,10);
        }
    }
}

void PrintArrey2(int[,] matr2)
{

for (int i = 0; i < matr2.GetLength(0); i++)
{
    for (int j = 0; j < matr2.GetLength(1); j++)
    {
        Console.Write($"   {matr2[i,j]}")   ;
    }
    Console.WriteLine();
}
}

void FillArrey2(int[,] matr2)
{
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr2[i,j]= new Random().Next(1,10);
        }
    }
}
 void SelectionSort(int[,] matr1,int[,] matr2)
{
     int pr1=0;
     int pr2=0;
     int pr3=0;
     int pr4=0;
     int pr5=0;
     int pr6=0;
     int pr7=0;
     int pr8=0;
     int pr9=0;
     int pr10=0;
     int pr11=0;
     int pr12=0;
    
     
        pr1=matr1[0,0]*matr2[0,0];
        pr2= matr1[0,1]*matr2[1,0];
        pr3=pr1+pr2;

        pr4=matr1[0,0]*matr2[0,1];
        pr5=matr1[0,1]*matr2[1,1];
        pr6=pr4+pr5;

        pr7=matr1[1,0]*matr2[0,0];
        pr8=matr1[1,1]*matr2[1,0];
        pr9=pr7+pr8;

        pr10= matr1[1,0]*matr2[0,1];
        pr11=matr1[1,1]*matr2[1,1];
        pr12=pr10+pr11;

        Console.Write($"Произведение двух матриц: {pr3}  {pr6}    ");
         Console.WriteLine();
         Console.Write($"                          {pr9}  {pr12}    ");
    }
     

         


int[,] matr1= new int[2,2];
int[,] matr2= new int[2,2];

Console.WriteLine("Первая матрица:");
FillArrey1(matr1);
PrintArrey1(matr1);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
FillArrey2(matr2);
PrintArrey2(matr2);
Console.WriteLine();
SelectionSort(matr1,matr2);
Console.WriteLine();
