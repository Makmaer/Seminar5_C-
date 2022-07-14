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

int PoiskChisla (int[] array, int chislo)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == chislo) index = i;
    }
    return index;
}

bool IsElementHere (int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] == num) return true;
    }
    return false;
}

Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMas(N,min,max);
PrintMas (myArray);
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
/*if(PoiskChisla(myArray, n) == (-1)) Console.WriteLine("Такого числа нет в массиве ");
else Console.WriteLine("Искомое число есть в массиве " );*/
/*Console.WriteLine(IsElementHere (myArray, n));*/
if(IsElementHere (myArray, n)) Console.WriteLine("Элемент есть");
else Console.WriteLine("Нет эл-та");