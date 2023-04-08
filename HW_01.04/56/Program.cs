// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
    int min=0;
    int count=0;
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        sum= (sum + matr[i, j]);
        count=count+1;
      
        
        
    }
  count=i+1;
    Console.WriteLine($"Сумма строки {count}: {sum}   ");
    }
}

    void MinimalLine (int[,] matr)
    {
        int res=0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                int sum1=matr[0,0]+matr[0,1]+matr[0,2];
                int sum2=matr[1,0]+matr[1,1]+matr[1,2];
                int sum3=matr[2,0]+matr[2,1]+matr[2,2];
                if(sum1<sum2 || sum1<sum3) res=1;
                else 
                if(sum2<sum1 || sum2<sum3) res=2;
                else 
                if(sum3<sum1 || sum3<sum2) res=3;
                 
            }
        }
Console.WriteLine($"Строка с наименьшей суммой элементов: {res}");
    }
    
int[,] matrix= new int[3,3];


FillArrey(matrix);
PrintArrey(matrix);
Console.WriteLine();
SelectionSort(matrix);
Console.WriteLine();
MinimalLine(matrix);

Console.WriteLine();

