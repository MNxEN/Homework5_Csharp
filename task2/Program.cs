// Задача 2: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
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

void PrintOddPositionSum(int[] Array)
{
    System.Console.WriteLine();
    int sum = 0;
    for (int i = 1; i < Array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += Array[i];
        }
    }
    System.Console.WriteLine($"Сумма значений на нечетных позициях = {sum}");
}

int lenArr = Prompt("Введите количество элементов массива");
int minArr = Prompt("Введите минимальное значение массива");
int maxArr = Prompt("Введите максимальное значение массива");
int[] numbers = GenerateArray(lenArr, minArr, maxArr);

PrintArray(numbers);

PrintOddPositionSum(numbers);

