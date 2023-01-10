// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] FillingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)

    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void Print(int[] Arr)
{
    foreach (int item in Arr)
        Console.Write(item + " ");
}


int[] Arr = new int[8];

Arr = FillingArray(Arr);
Console.Write(" [");
Print(Arr);
Console.WriteLine("]");