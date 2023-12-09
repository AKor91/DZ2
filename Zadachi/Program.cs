// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int[] array = new int[10];
// int kolElement = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,101);
//     Console.Write(array[i]+ " ");
// }
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] > 19 && array[i] < 91)
//     {
//         kolElement = kolElement +1;
//     }
// }
// Console.WriteLine("Количество элементов, в отрезке [20, 90] = " +kolElement);


// Задача 2: Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int[] array = new int[10];
// int element = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1,50);
//     Console.Write(array[i]+ " ");
// }
// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i]%2 == 0)
//     {
//         element = element +1;
//     }
// }
// Console.WriteLine("Количество четных элементов в массиве = " +element);


// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[10];

// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble();
//     Console.Write(array[i]+ " ");
// }

// double max = array[0];
// double min = array[0];
// double raz = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }

// raz = max - min;

// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine("max = " +max);
// Console.WriteLine();
// Console.WriteLine("min = " +min);
// Console.WriteLine();
// Console.WriteLine("Разница между max и min = " +raz);


// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив,
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе
// массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0 && num < 100001)
{   
    int n = 0;
    int temp = num;
    
    while(temp % 10 > 0)
    {
        temp = temp / 10;
        n = n + 1;
    }
    
    int[] array = new int[n];
    temp = num;
       
    for(int i = 0; i < array.Length; i++)
    {
       array[i] = temp % 10;
       temp = temp / 10;
       Console.Write(array[i]+ " ");
    }
}
else
{
    Console.WriteLine("Число не подходит");
}