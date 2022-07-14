
int[] RandomMasInt (int size, int ot, int doo)

{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(ot, doo + 1);
    }
    return array;
}

double[] RandomMasDoubl (int size, int ot, int doo)

{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
     array[i] =Math.Round(new Random().Next(ot, doo ) + new Random().NextDouble(), 3)  ;
    }
    return array;
}

void PrintMasInt (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintMasDob (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int KolChetnieChisla (int[] array)
{
    int schetchik = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == 0 ) schetchik = schetchik + 0;
        else if (array[i] %2 == 0 ) schetchik ++;
    }
    return schetchik; 
}

int SumElementsNechetnPosition (int[] array)
{
    int sum=0; int i = 1;
    while (i < array.Length) 
    {
        sum = array[i]+sum; i = i + 2;
    }
    return sum;
}

double MaxElMas(double[] array)
{
   int position = 0;
   int maxIndex = 0;
   double result = array[0];
   while (position < array.Length)
   {
     if(array[position] > result) {result = array[position]; maxIndex=position;}
     position++;}
    return result; 
}

double MinElMas(double[] array)
{
   int position = 0;
   int minIndex = 0;
   double result = array[0];
   while (position < array.Length)
   {
     if(array[position] < result) {result = array[position]; minIndex=position;}
     position++;}
    return result; 
}

double RaznicaMinMax(double a, double b)
{
double s = a-b;
return  s;
}
//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMasInt(N,min,max);
PrintMasInt (myArray);
Console.WriteLine("Кол-во четных чисел = " + KolChetnieChisla(myArray));

//Задача 36: 
//Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomMasInt(N,min,max);
PrintMasInt (myArray);
Console.WriteLine("Сумма эл-тов на нечетных позициях = " + SumElementsNechetnPosition(myArray));
*/



//Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Макс= ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Мин= ");
int min = Convert.ToInt32(Console.ReadLine());
double[] myArray = RandomMasDoubl(N,min,max);
PrintMasDob (myArray);
Console.WriteLine("Разница между мин и макс эл-тами массива = " + RaznicaMinMax(MaxElMas(myArray), MinElMas(myArray)));
*/