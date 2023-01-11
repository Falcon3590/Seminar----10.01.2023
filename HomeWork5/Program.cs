// Задача HARD STAT необязательная: 
// 1. Задайте массив случайных целых чисел. 
// 2. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс,
// 3. среднее арифметическое всех элементов. 
// 4. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// 5. Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

int[] array = new int[10];
int MaxNumber;
int MaxIndex;
int MinNumber;
int MinIndex;

// 1. Задайте массив случайных целых чисел. 
FillingArray(array);
Console.Write("[ ");
Print(array);
Console.Write($"]\n");

// 2. Найдите максимальный элемент и его индекс, минимальный элемент и его индекс
SearchMinAndMaxElement(array, out MaxNumber, out MaxIndex, out MinNumber, out MinIndex);
// Console.WriteLine($"Максимальный элемент {MaxNumber} и его индекс {MaxIndex}, минимальный элемент {MinNumber} и его индекс {MinIndex}");

// 3. среднее арифметическое всех элементов
double middle = array.Average();
// Console.WriteLine($"Среднее арифметическое всех элементов массива = {middle}");

// 5. Найти медианное значение первоначалального массива.
var mediana = Mediana(array);
mediana = Convert.ToDouble(mediana);
// Console.WriteLine($"Медианное значение массива = {mediana}");

// 4. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
ResultArray();

int[] FillingArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Random rnd = new Random();

        array[i] = rnd.Next(1, 100);
    }
    return array;
}

void SearchMinAndMaxElement(int[] array, out int MaxNumber, out int MaxIndex, out int MinNumber, out int MinIndex)
{
    MaxNumber = array[0];
    MinNumber = array[0];
    MaxIndex = 0;
    MinIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > MaxNumber)
        {
            MaxNumber = array[i];
            MaxIndex = i;
        }

        if (array[i] < MinNumber)
        {
            MinNumber = array[i];
            MinIndex = i;
        }

    }
}

void Print(int[] array)
{
    foreach (int item in array)
        Console.Write(item + " ");
}

object Mediana(int[] arr)
{
    //считаем общую сумму
    var sum = arr.Sum();
    //перебираем элементы, пока не достигнем 50% от суммы:
    var temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        temp += arr[i];
        if (temp >= sum / 2)
            return i;
    }

    return arr.Length;
}

void ResultArray()
{
    string[] Result = { "Максимальный элемент = " + MaxNumber + " его индекс = " + MaxIndex,
    "Минимальный элемент = " + MinNumber + " его индекс = " + MinIndex,
    "Среднее арифметическое всех элементов массива = " + middle,
    "Медианное значение массива = " + mediana};

    for (int i = 0; i < Result.Length; i++)
        Console.WriteLine(Result[i]);
    Console.ReadKey();
}



