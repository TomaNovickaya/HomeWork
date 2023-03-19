// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arr ={7,9,4,3,2,6,8};
int maxPosition=0;
int minPosition=0;
int res=0;
void PrintArrey(int [] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"    {arrey[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        int minPosition=i;
        for (int j = i+1; j < arrey.Length; j++)
        {
            if(arrey[j] < arrey[minPosition]) 
            {
            minPosition=j;
            }
        }
               arrey[i] = arrey[minPosition];
           }
           Console.WriteLine($" Миниальный элемент: {arrey[minPosition]}");
}
PrintArrey(arr);
SelectionSort(arr);

void SelectionSort2(int[] arrey)
{
    for (int i = 0; i < arrey.Length; i++)
    {
        int maxPosition=i;
        for (int j = i+1; j < arrey.Length; j++)
        {
            if(arrey[j] > arrey[maxPosition]) 
            {
            maxPosition=j;
            }
        }

                arrey[i] = arrey[maxPosition];
                res= maxPosition-minPosition;
            }
            Console.WriteLine($" Максимальный элемент: {arrey[maxPosition]}");
            Console.WriteLine($" Разница между максимальным и минимальным элементами: {res}");
}

SelectionSort2(arr);


