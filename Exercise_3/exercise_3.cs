// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


using System;
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
    Random rand = new Random();
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-99, 99);
        Console.Write(array[i] + " ");
    }
    int j = 0;
    int min = array[0];
    while(j < array.Length)
    {
        if (array[j] < min)
        {
            min = array[j];
            j++;
        }
        else
        {
            j++;
        }
    }
    int k = 0;
    int max = array[0];
    while(k < array.Length)
    {
        if (array[k] > max)
        {
            max = array[k];
            k++;
        }
        else
        {
            k++;
        }
    }
    Console.WriteLine("");
    Console.WriteLine("Разница между максимальным и минимальным значением массива: ");
    Console.WriteLine(max - min);
}