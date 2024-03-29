﻿// Задача 68: Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ANumber(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0) 
    {
    return ANumber(m - 1, 1);
    }
    return (ANumber(m - 1, ANumber(m, n - 1)));


}
Console.WriteLine(ANumber(3,2));