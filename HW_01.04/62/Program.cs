// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] matrix = new int[4,4] {{01,02,03,04},
                              {05,06,07,08},
                              {09,10,11,12},
                              {13,14,15,16}};


void PrintArrey(int[,] matr)
{
 for (int i = 0; i < matr.GetLength(0); i++)
 {
 for (int j = 0; j < matr.GetLength(1); j++)
 {
  Console.Write($"{matr[i,j]}  ");
 }
 Console.WriteLine();
 }
}

void FillArrey(int[,] matr)
{
    int temp1=matr[1,0];
    int temp2=matr[1,3];
    int temp3=matr[1,1];
    int temp4=matr[2,3];
    int temp5=matr[1,2];
    int temp6=matr[3,3];
    int temp7=matr[3,2];
    int temp8=matr[3,1];
    int temp9=matr[2,0];
    int temp10=matr[2,1];
    int temp11=matr[3,0];
    int temp12=matr[2,2];
    
    
    
   for (int i = 0; i < matr.GetLength(0); i++)
   {
    for (int j = i+1; j < matr.GetLength(1); j++)
    {
        
            
            matr[1,0]=temp2;
            matr[1,3]=temp1;
            matr[1,1]=temp4;
            matr[2,3]=temp3;
            matr[1,2]=temp6;
            matr[3,3]=temp5;
            matr[1,0]=temp7;
            matr[3,2]=temp2;
            matr[3,1]=temp9;
            matr[3,0]=temp10;
            matr[2,0]=temp12;
            matr[1,0]=temp4;
            matr[1,1]=temp11;
            matr[1,2]=temp8;
            matr[2,2]=temp7;
            matr[2,1]=temp6;

            
            
    
    }
   }
}

FillArrey(matrix);
PrintArrey(matrix);
