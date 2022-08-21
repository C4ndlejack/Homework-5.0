// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;
{
    Console.WriteLine("Введите размер массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
    Random rand = new Random();
    Console.WriteLine("Ваш массив: ");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(100, 999);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine("Все чётные числа в диапазоне: ");
    int j = 0;
    while (j < array.Length)
    {
        if(array[j] % 2 == 0)
        {
            Console.Write(array[j] + " ");
            j++;
        }
        else
        {
            j++;
        }
    }
}