﻿// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int PromptPositive(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value) && value >= 0)
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым положительным числом");
    Environment.Exit(0);
    return 0;
}

int[] GenerateArray(int len, int min, int max)		
{
    int[] list1 = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < list1.Length; i++)
    {
        list1[i] = rnd.Next(min, max + 1);
    }
    return list1;
}

void PrintArray(int[] Array)				
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.Write(Array[i] + " ");
    }
    System.Console.WriteLine();
}

void PrintEvenCount(int[] Array)				
{
System.Console.WriteLine();
int count = 0;
foreach (var item in Array)
{
    if (item % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных элементов = {count}");
}

int lenArr = PromptPositive("Введите количество элементов массива");
int[] numbers = GenerateArray(lenArr, 100, 999);

PrintArray(numbers);

PrintEvenCount(numbers);
