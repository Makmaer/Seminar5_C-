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

int[] Zamena (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array[i] * (-1);
        
    }
   return array;
}

System.Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMas(N,min,max);
PrintMas (myArray);
Zamena (myArray);
PrintMas (myArray);
