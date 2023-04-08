// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArrey(int[,,] matr)
{

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
             Console.Write($"   {matr[i,j,k]}")   ;
        }
       
    }
    Console.WriteLine();
}
}

void FillArrey(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i,j,k]= new Random().Next(10,100);
            }
            
        }
    }
}

void SelectionSort(int[,,] matr)
{
 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                 if(matr[i,j,k]!= matr[i,j,k]+1)
                 {
                Console.WriteLine($"[ {matr[0,0,0]} (0,0,0)  {matr[0,1,0]} (0,1,0) ]");
                Console.WriteLine();
                
                Console.WriteLine($"[ {matr[1,0,0]} (1,0,0)  {matr[1,1,0]} (1,1,0) ]");
                Console.WriteLine();
                
                Console.WriteLine($"[ {matr[2,0,0]} (0,0,1)  {matr[2,1,0]} (0,1,1) ]");
                Console.WriteLine();
                break;
                }
                
            }
        }
        }
    }
 
int[,,] matrix= new int[3,2,1];

FillArrey(matrix);
PrintArrey(matrix);
Console.WriteLine();
SelectionSort(matrix);
Console.WriteLine();
