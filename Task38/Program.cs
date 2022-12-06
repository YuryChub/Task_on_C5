// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
          array[i] = new Random().NextDouble()*100;
}


void ReleaseArray(double[] array)
{
    double Max = 0, Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max)
            Max = array[i];
        if (array[i] < Min)
            Min = array[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива {Math.Round(Max-Min,2)}");
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);