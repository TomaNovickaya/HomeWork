// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Console.Write("Введите пятизначное число: ");
//int numberA = Convert.ToInt32(Console.ReadLine());
int[] arrey = new int[5] {2,3,4,3,3};


for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[0]==arrey[4] && arrey[1]==arrey[3])
    {
Console.WriteLine($"Пятизначное число:  {arrey[0]}{arrey[1]}{arrey[2]}{arrey[3]}{arrey[4]}");
Console.WriteLine($"Палиндром!");
break;

    }
    else
Console.WriteLine($"Пятизначное число: {arrey[0]}{arrey[1]}{arrey[2]}{arrey[3]}{arrey[4]}");
    Console.WriteLine($"Не палиндром!");
    break;
    }
