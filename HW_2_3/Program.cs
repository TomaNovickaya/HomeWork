// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number==1)
{
    Console.WriteLine("Понедельник");
}
else
{
    if (number==2)
{
    Console.WriteLine("Вторник");
}

else
{
    if (number==3)
{
    Console.WriteLine("Среда");
}

else
{
    if (number==4)
{
    Console.WriteLine("Четверг");
}
else
{
    if (number==5)
{
    Console.WriteLine("Пятница");
}
else
{
    if (number==6)
{
    Console.WriteLine("Суббота");
}
else
{
    if (number==7)
{
    Console.WriteLine("Воскресенье");
}
}
}
}
}
}
}
for (int i = 1; i < 8; i++)
{
    if (number<=5)
    {
        Console.WriteLine("Будни");
        break;
    }
    else
    if(number>5)
    {
        Console.WriteLine("Выходные");
        break;
    }
}