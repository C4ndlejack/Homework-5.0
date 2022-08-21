// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

    Console.WriteLine("");
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях массива: ");
    int j = 1;
    int sum = 0;
    while(j < array.Length)
    {
        sum += array[j];
        j += 2;
    }
    Console.WriteLine(sum);
}    