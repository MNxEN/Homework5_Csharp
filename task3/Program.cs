// Задача 3: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int PromptInt(string message)
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
double PromptDouble(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    double value;
    if (double.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является числом");
    Environment.Exit(0);
    return 0;
}

double[] GenerateArray(int len, double min, double max)
{
    double[] array = new double[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * ((max)-(min))+(min),2); 

    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

(double, double) MinMax(double[]numbers)
{
    double min = numbers[0];
    double max = numbers[0];
for (int i=0; i < numbers.Length; i++)
{
  if (min> numbers[i])
  {
    min = numbers[i];
  }
  if (max<numbers[i])
  {
    max = numbers[i];
  }
}
return(min,max);
}

int lenArr = PromptInt("Введите количество элементов массива");
double minArr = PromptDouble("Введите минимальное значение массива");
double maxArr = PromptDouble("Введите максимальное значение массива");

double[] numbers = GenerateArray(lenArr, minArr, maxArr);

(double min,double max) = MinMax(numbers);

PrintArray(numbers);

double diff = Math.Round(max-min,2);

System.Console.WriteLine($"\n{min} - минимальный элемент массива, {max} - максимальный элемент массива. Разница = {diff}");