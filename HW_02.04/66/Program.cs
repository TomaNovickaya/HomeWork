// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int n,int m)
{
    if(n==0) return 0;
    else return n + SumNumber(n-1,m);
    
    
}
Console.WriteLine($"{SumNumber(15,0)}");
