// 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел боль 0 ввел пользователь.

int[] nums=new int [5];

void PrintArrey(int [] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        int x = new Random().Next(-5,6);
        arrey[i]=x;
        Console.Write($"   {arrey[i]}");
    }
    Console.WriteLine();
   
}
 PrintArrey(nums);
int count=0;

for (int i = 0; i < nums.Length; i++)
{
   
    if (nums[i]>0)  
    {
    count+=1;
    }
           
        
        
    
}
Console.WriteLine(count);

