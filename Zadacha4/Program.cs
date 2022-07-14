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

int DvuznachChisla (int[] array)
{
    int schetchik = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99 ) schetchik ++;
    }
    return schetchik;
}

Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMas(N,min,max);
PrintMas (myArray);
Console.WriteLine("Кол-во чисел от 10 до 99 = " + DvuznachChisla(myArray));



