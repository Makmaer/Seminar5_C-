int[] RandomMas (int size, int ot, int doo)

{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(ot, doo + 1);
    }
    return array;
}

void PrintMas (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumPoloz (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int SumOtric (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

System.Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMas(N,min,max);
PrintMas (myArray);
Console.WriteLine("Сумма положительных эл-тов = " + SumPoloz(myArray));
Console.WriteLine("Сумма отрицательных эл-тов = " + SumOtric(myArray));